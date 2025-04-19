using Microsoft.JSInterop;
using System.Text.Json;

namespace front__wasm.Services
{
    public class CartService
    {
        private List<Pages.Cart.CartItemModel> _cartItems = new List<Pages.Cart.CartItemModel>();
        private readonly IJSRuntime? _jsRuntime;
        private bool _initialized = false;

        public event Action? OnChange;

        public IReadOnlyList<Pages.Cart.CartItemModel> CartItems => _cartItems.AsReadOnly();

        public int Count => _cartItems.Sum(item => item.Quantity);

        public CartService(IJSRuntime? jsRuntime = null)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            if (_initialized)
                return;

            if (_jsRuntime != null)
            {
                try
                {
                    var storedCart = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "cartItems");

                    if (!string.IsNullOrEmpty(storedCart))
                    {
                        var savedItems = JsonSerializer.Deserialize<List<Pages.Cart.CartItemModel>>(storedCart);
                        if (savedItems != null && savedItems.Any())
                        {
                            _cartItems = savedItems;
                            NotifyStateChanged();
                        }
                    }
                }
                catch
                {
                    AddDefaultItems();
                }
            }
            else
            {
                AddDefaultItems();
            }

            _initialized = true;
        }

        private void AddDefaultItems()
        {
            if (!_cartItems.Any())
            {
                _cartItems.Add(new Pages.Cart.CartItemModel
                {
                    ImageUrl = "https://via.placeholder.com/80?text=Gold",
                    ImageAlt = "Gold Service",
                    Title = "Gold Service",
                    Description = "10.000 Gold",
                    UnitPrice = "R$ 19,90",
                    Quantity = 1
                });

                _cartItems.Add(new Pages.Cart.CartItemModel
                {
                    ImageUrl = "https://via.placeholder.com/80?text=Gold",
                    ImageAlt = "Gold Service",
                    Title = "Gold Service Premium",
                    Description = "50.000 Gold",
                    UnitPrice = "R$ 79,90",
                    Quantity = 1
                });
            }
        }

        public void AddItem(Pages.Cart.CartItemModel item)
        {
            var existingItem = _cartItems.FirstOrDefault(i =>
                i.Title == item.Title &&
                i.Description == item.Description);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _cartItems.Add(item);
            }

            SaveCartToStorage();
            NotifyStateChanged();
        }

        public void UpdateQuantity(Pages.Cart.CartItemModel item, int newQuantity)
        {
            var existingItem = _cartItems.FirstOrDefault(i => i == item);
            if (existingItem != null)
            {
                existingItem.Quantity = newQuantity;
                SaveCartToStorage();
                NotifyStateChanged();
            }
        }

        public void RemoveItem(Pages.Cart.CartItemModel item)
        {
            _cartItems.Remove(item);
            SaveCartToStorage();
            NotifyStateChanged();
        }

        public void ClearCart()
        {
            _cartItems.Clear();
            SaveCartToStorage();
            NotifyStateChanged();
        }

        private async void SaveCartToStorage()
        {
            if (_jsRuntime != null)
            {
                try
                {
                    var cartJson = JsonSerializer.Serialize(_cartItems);
                    await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "cartItems", cartJson);
                }
                catch
                { }
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
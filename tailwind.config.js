/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html,cshtml,css}"],
  safelist: [
    {
      pattern: /bg-(indigo|yellow|green|red|purple)-600\/(20|30)/,
    },
    // You might also need to safelist the hover border colors if they are dynamic
    // Example: { pattern: /hover:border-(indigo|yellow|green|red|purple)-500/ }
    // Add based on the actual values used in HoverBorderColor
    "hover:border-indigo-500",
    "hover:border-yellow-500",
    "hover:border-green-500",
    "hover:border-red-500",
    "hover:border-purple-500",
  ],
  theme: {},
  plugins: [],
};

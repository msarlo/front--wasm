/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html,cshtml,css}"],
  theme: {
    extend: {
      fontFamily: {
        sans: ["Inter", "sans-serif"],
        display: ["Special Gothic Condensed One", "sans-serif"],
        mono: ["Fira Code", "monospace"],
      },
      colors: {
        glass: "rgba(255, 255, 255, 0.2)",
      },
    },
  },
  plugins: [],
};

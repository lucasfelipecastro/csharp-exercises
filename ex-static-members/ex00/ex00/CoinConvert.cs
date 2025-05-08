namespace ex00 {
    class CoinConvert {
        public static double Iof = 6.0;

        public static double ConvertDollarToBrl(double quote, double amount) {
            double total = quote * amount;
            return total * (1 + Iof / 100.0);
        }
    }
}
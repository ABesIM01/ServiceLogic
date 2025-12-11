namespace WinFormsApp2.Service
{
    public class ServiceOrder
    {
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public string Option { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            string result = $"{ServiceName} × {Quantity}";

            if (!string.IsNullOrWhiteSpace(Option))
                result += $" ({Option})";

            if (!string.IsNullOrWhiteSpace(Notes))
                result += $" [{Notes}]";

            return result;
        }
    }
}

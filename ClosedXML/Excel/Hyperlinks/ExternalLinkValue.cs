using System;

namespace ClosedXML.Excel
{
    public class ExternalLinkValue
    {
        public ExternalLinkValue(Uri uri, string displayValue = null, string tooltip = null)
        {
            this.DisplayValue = displayValue;
            this.Uri = uri;
            this.Tooltip = tooltip;
        }

        public string DisplayValue { get; }

        public Uri Uri { get; }

        public string Tooltip{ get; }

        public void Valildate()
        {
            if (string.IsNullOrEmpty(this.DisplayValue) && this.Uri is null)
                throw new ArgumentException("Display value and uri cannot be undefined at the same time");
        }

    }
}

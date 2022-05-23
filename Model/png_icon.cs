using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather.Model
{
    class png_icon: XPCustomObject
    {
        #region connection

        public png_icon(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        #endregion

        #region value
        decimal fpng_id;
        [Key]
        public decimal png_id
        {
            get { return fpng_id; }
            set { SetPropertyValue<decimal>(nameof(png_id), ref fpng_id, value); }
        }
        decimal fpng_id_weather;
        public decimal png_id_weather
        {
            get { return fpng_id_weather; }
            set { SetPropertyValue<decimal>(nameof(png_id_weather), ref fpng_id_weather, value); }
        }
        string fpng_main;
        [Size(SizeAttribute.Unlimited)]
        public string png_main
        {
            get { return fpng_main; }
            set { SetPropertyValue<string>(nameof(png_main), ref fpng_main, value); }
        }
        string fpng_description;
        [Size(SizeAttribute.Unlimited)]
        public string png_description
        {
            get { return fpng_description; }
            set { SetPropertyValue<string>(nameof(png_description), ref fpng_description, value); }
        }
        string fpng_icon_path;
        [Size(50)]
        public string png_icon_path
        {
            get { return fpng_icon_path; }
            set { SetPropertyValue<string>(nameof(png_icon_path), ref fpng_icon_path, value); }
        }
        #endregion
    }
}

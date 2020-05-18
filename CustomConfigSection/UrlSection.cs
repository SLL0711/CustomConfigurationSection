using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConfigurationSection.CustomConfigSection
{
    public class UrlSection : ConfigurationSection
    {
        [ConfigurationProperty("name")]
        public string Name
        {
            get
            {
                return this["name"].ToString();
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("simple")]
        public UrlElement Simple
        {
            get
            {
                return ((UrlElement)this["simple"]);
            }
            set
            {
                this["simple"] = value;
            }
        }

        [ConfigurationProperty("urls")]
        [ConfigurationCollection(typeof(UrlElementCollection), AddItemName = "url")]
        public UrlElementCollection urls
        {
            get
            {
                return ((UrlElementCollection)this["urls"]);
            }
            set
            {
                this["urls"] = value;
            }
        }
    }
}

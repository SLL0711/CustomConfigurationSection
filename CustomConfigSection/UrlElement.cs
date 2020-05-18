using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CustomConfigurationSection.CustomConfigSection
{
    public class UrlElement : ConfigurationElement
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

        [ConfigurationProperty("baseurl")]
        public string BaseUrl
        {
            get
            {
                return base["baseurl"].ToString();
            }
        }

        [ConfigurationProperty("port")]
        public string Port
        {
            get
            {
                return base["port"].ToString();
            }
        }
        [ConfigurationProperty("query")]
        public string Query
        {
            get
            {
                return base["query"].ToString();
            }
        }
    }
}

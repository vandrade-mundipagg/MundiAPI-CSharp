/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    public class GetPeriodResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime startAt;
        private DateTime endAt;
        private string id;
        private DateTime billingAt;
        private Models.GetSubscriptionResponse subscription;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime StartAt 
        { 
            get 
            {
                return this.startAt; 
            } 
            set 
            {
                this.startAt = value;
                onPropertyChanged("StartAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_at")]
        public DateTime EndAt 
        { 
            get 
            {
                return this.endAt; 
            } 
            set 
            {
                this.endAt = value;
                onPropertyChanged("EndAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime BillingAt 
        { 
            get 
            {
                return this.billingAt; 
            } 
            set 
            {
                this.billingAt = value;
                onPropertyChanged("BillingAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription 
        { 
            get 
            {
                return this.subscription; 
            } 
            set 
            {
                this.subscription = value;
                onPropertyChanged("Subscription");
            }
        }
    }
} 
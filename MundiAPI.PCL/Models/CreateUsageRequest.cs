/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
    public class CreateUsageRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int quantity;
        private string description;
        private DateTime usedAt;
        private string code;
        private string mgroup;
        private int? amount;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("used_at")]
        public DateTime UsedAt 
        { 
            get 
            {
                return this.usedAt; 
            } 
            set 
            {
                this.usedAt = value;
                onPropertyChanged("UsedAt");
            }
        }

        /// <summary>
        /// Identification code in the client system
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// identification group in the client system
        /// </summary>
        [JsonProperty("group")]
        public string Group 
        { 
            get 
            {
                return this.mgroup; 
            } 
            set 
            {
                this.mgroup = value;
                onPropertyChanged("Group");
            }
        }

        /// <summary>
        /// Field used in item scheme type 'Percent'
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }
    }
} 
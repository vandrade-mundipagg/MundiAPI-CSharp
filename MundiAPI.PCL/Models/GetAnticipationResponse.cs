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
    public class GetAnticipationResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private int requestedAmount;
        private int approvedAmount;
        private Models.GetRecipientResponse recipient;
        private string pgid;
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime paymentDate;
        private string status;
        private string timeframe;

        /// <summary>
        /// Id
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
        /// Requested amount
        /// </summary>
        [JsonProperty("requested_amount")]
        public int RequestedAmount 
        { 
            get 
            {
                return this.requestedAmount; 
            } 
            set 
            {
                this.requestedAmount = value;
                onPropertyChanged("RequestedAmount");
            }
        }

        /// <summary>
        /// Approved amount
        /// </summary>
        [JsonProperty("approved_amount")]
        public int ApprovedAmount 
        { 
            get 
            {
                return this.approvedAmount; 
            } 
            set 
            {
                this.approvedAmount = value;
                onPropertyChanged("ApprovedAmount");
            }
        }

        /// <summary>
        /// Recipient
        /// </summary>
        [JsonProperty("recipient")]
        public Models.GetRecipientResponse Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// Anticipation id on the gateway
        /// </summary>
        [JsonProperty("pgid")]
        public string Pgid 
        { 
            get 
            {
                return this.pgid; 
            } 
            set 
            {
                this.pgid = value;
                onPropertyChanged("Pgid");
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime PaymentDate 
        { 
            get 
            {
                return this.paymentDate; 
            } 
            set 
            {
                this.paymentDate = value;
                onPropertyChanged("PaymentDate");
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe")]
        public string Timeframe 
        { 
            get 
            {
                return this.timeframe; 
            } 
            set 
            {
                this.timeframe = value;
                onPropertyChanged("Timeframe");
            }
        }
    }
} 
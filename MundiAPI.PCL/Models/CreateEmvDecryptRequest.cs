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
    public class CreateEmvDecryptRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string iccData;
        private string cardSequenceNumber;
        private Models.CreateEmvDataDecryptRequest data;
        private Models.CreateCardPaymentContactlessPOIRequest poi;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("icc_data")]
        public string IccData 
        { 
            get 
            {
                return this.iccData; 
            } 
            set 
            {
                this.iccData = value;
                onPropertyChanged("IccData");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("card_sequence_number")]
        public string CardSequenceNumber 
        { 
            get 
            {
                return this.cardSequenceNumber; 
            } 
            set 
            {
                this.cardSequenceNumber = value;
                onPropertyChanged("CardSequenceNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("data")]
        public Models.CreateEmvDataDecryptRequest Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("poi")]
        public Models.CreateCardPaymentContactlessPOIRequest Poi 
        { 
            get 
            {
                return this.poi; 
            } 
            set 
            {
                this.poi = value;
                onPropertyChanged("Poi");
            }
        }
    }
} 
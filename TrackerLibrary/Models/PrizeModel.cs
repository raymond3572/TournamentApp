﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    public class PrizeModel
    {
        /// <summary>
        /// The Unique identifier for the prize.
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Represents the place number
        /// </summary>
        
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name
        /// </summary>

        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount
        /// </summary>

        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize persecentage
        /// </summary>

        public double PrizePercentage { get; set; }


        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

        public PrizeModel()
        {
        }
    }
}

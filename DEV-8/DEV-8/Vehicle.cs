﻿using System;

namespace DEV8
{
    /// <summary>
    /// Represents vehicle entity.
    /// </summary>
    public class Vehicle
    {        
        public string Brand { get; }
        public string Model { get; }
        public int Quantity { get; set;}
        public double UnitCost;

        /// <summary>
        /// Initialize new vehicle object.
        /// </summary>
        /// <param name="brand">Brand of vehicle.</param>
        /// <param name="model">Model of vehicle.</param>
        /// <param name="quantity">Quantity of vehicle.</param>
        /// <param name="unitCost">Cost of one vehicle.</param>
        public Vehicle(string brand, string model, int quantity, double unitCost)
        {
            Brand = brand;
            Model = model;           
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity of vehicle must be positive");
            }
            else
            {
                Quantity = quantity;
            }
            if (unitCost <= 0.0)
            {
                throw new ArgumentException("Price of vehicle must be positive");
            }
            else
            {
                UnitCost = unitCost;
            }
        }        
    }
}


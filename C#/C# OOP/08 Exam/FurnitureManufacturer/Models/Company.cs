﻿namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Interfaces;

    public class Company : ICompany
    {
        private const string NameNullOrEmptyErrorMessage = "The name of the company cannot be null or empty";
        private const int NameMinimumLength = 5;
        private const string NameMinimumLengthErrorMessage = "The name must be at least {0} symbols long";
        private const int RegistrationNumberLength = 10;
        private const string RegistrationNumberLengthErrorMessage = "The registration number must be exactly {0} symbols";
        private const string RegistrationNumberParseErrorMessage = "The registration number must contain only digits";

        private string name;
        private string registrationNumber;
        private long regNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullOrEmptyErrorMessage);
                }

                if (value.Length < NameMinimumLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format(NameMinimumLengthErrorMessage, NameMinimumLength));
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (value.Length != RegistrationNumberLength)
                {
                    throw new ArgumentOutOfRangeException(string.Format(RegistrationNumberLengthErrorMessage, RegistrationNumberLength));
                }

                if (!long.TryParse(value, out this.regNumber))
                {
                    throw new InvalidOperationException(RegistrationNumberParseErrorMessage);
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get;
            private set;
        }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            // TODO: Do I have to search if there is an existing one first?
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            var foundFurniture = this.Furnitures
                .Where(fur => fur.Model.ToLower() == model.ToLower())
                .FirstOrDefault();

            return foundFurniture;
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.ToString());

            if (this.Furnitures.Count > 0)
            {
                var orderedFurnitures = this.Furnitures
                    .OrderBy(fur => fur.Price)
                    .ThenBy(fur => fur.Model);

                foreach (var furniture in orderedFurnitures)
                {
                    result.AppendLine(furniture.ToString());
                }
            }

            return result.ToString().Trim();
        }

        public override string ToString()
        {
            string result = string.Format(
                "{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            return result;
        }
    }
}

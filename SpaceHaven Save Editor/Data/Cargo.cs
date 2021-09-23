﻿using ReactiveUI;
using SpaceHaven_Save_Editor.References;

namespace SpaceHaven_Save_Editor.Data
{
    public class Cargo : ReactiveObject
    {
        private int _cargoAmount;

        public Cargo(int cargoId, int cargoAmount)
        {
            if (IdCollection.DefaultItemIDs.TryGetValue(cargoId, out var cargoName))
            {
                CargoId = cargoId;
                CargoName = cargoName;
                CargoAmount = cargoAmount;
            }
            else
            {
                CargoId = -1;
                CargoName = "ID: " + cargoId + " Not Found";
                CargoAmount = -1;
            }
        }

        public int CargoId { get; }

        public string CargoName { get; }

        public int CargoAmount
        {
            get => _cargoAmount;
            set => this.RaiseAndSetIfChanged(ref _cargoAmount, value);
        }
    }
}
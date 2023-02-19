using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProj_Shimon
{
    class Car
    {
        private string _manufacturer; // יצרן
        private string _model; // דגם
        private int _creatYear; //שנת יצור
        private string _IdPlate; // לוחית זיהוי
        private string _ownerFirstName; // שם פרטי בעלים
        private string _ownerLastName; // שם משפחה בעלים
        private string _owner_Id; // תעודת זהות בעלים

        public Car(string manufacturer, string model, int creatYear, string IdPlate, string ownerFirstName, string ownerLastName, string owner_Id)
        {
            this._manufacturer = manufacturer;
            this._model = model;
            this._creatYear = creatYear;
            this._IdPlate = IdPlate;
            this._ownerFirstName = ownerFirstName;
            this._ownerLastName = ownerFirstName;
            this._owner_Id = owner_Id;
        }

        public string GetPlat() => this._IdPlate;

        public string GetManufacturer() => this._manufacturer;

        public string GetModel() => this._model;

        public void SetManufacturer(string factory) => this._manufacturer = factory;

        public void SetModel(string model) => this._model = model;

        public string GetOwnerId() => this._owner_Id;

    }
}

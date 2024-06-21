﻿namespace PrototypeDesignPattern
{
    //The Prototype Abstract Class
    //This is an abstract class which is used for the types of object that can be cloned itself.
    public abstract class Employee
    {
        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Type { get; set; }

        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
}

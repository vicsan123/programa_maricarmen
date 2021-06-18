using System;
using System.Collections.Generic;
using System.Text;
using AutoBogus;

namespace TabbedSample.Services
{
    using Models;
    public class Singleton
    {
        private static Singleton _Instance;
        public static Singleton Instance
        {
            get => (_Instance == null) ? _Instance = new Singleton() : _Instance;
        }
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; }
        public List<Tratamiento> Tratamientos { get; set; }
        public decimal GananciaDiaria { get; set; }
        public decimal GananciaMensual { get; set; }

        public Singleton()
        {
            InitSingletonHelper();
        }
        public void InitSingletonHelper()
        {
            Clientes = AutoBogus.AutoFaker.Generate<Cliente>(30);
            Productos = AutoBogus.AutoFaker.Generate<Producto>(20);
            Tratamientos = AutoBogus.AutoFaker.Generate<Tratamiento>(20);


        }

    }
}

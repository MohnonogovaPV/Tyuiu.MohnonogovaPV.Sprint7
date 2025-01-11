
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MohnonogovaPV.Sprint7.Project.V13.Lib;

namespace Tyuiu.MohnonogovaPV.Sprint7.Project.V13.Tests
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestSortMin()
        {
            string[,] Matrix =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            string[,] res = ds.SortMin(Matrix, 3);
            string[,] wait =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSortMax()
        {
            string[,] Matrix =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            string[,] res = ds.SortMax(Matrix, 3);
            string[,] wait =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestSearch()
        {
            string[,] Matrix =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            string[,] res = ds.Search(Matrix, "Canada", 1);
            string[,] wait =
            {
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestCountryExist()
        {
            string[,] Matrix =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            bool res = ds.CountryExist(Matrix, "Canada");
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        
        [TestMethod]
        public void TestArrayStrWordsElements()
        {
            string[,] DataTable =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            string[] res = ds.ArrayStrWordsElements(DataTable, 6);
            string[] wait = { "Russian", "Canadian", "Chinese", "Australian" };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestArraySumWords()
        {
            string[,] DataTable =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            int[] res = ds.ArraySumWords(DataTable, ds.ArrayStrWordsElements(DataTable, 6), 6);
            int[] wait = { 1, 1, 1, 1 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestAverage()
        {
            string[,] DataTable =
            {
                {"ID","Country","Capital","Area","Developed","Population","Nationality"},
                {"1","Russia","Moscow","17098242","Yes","144104080","Russian"},
                {"2","Canada","Ottawa","9984670","Yes","37742154","Canadian"},
                {"3","China","Beijing","9596961","Yes","1402112332","Chinese"},
                {"4","Australia","Canberra","7692024","Yes","25499884","Australian"},
            };

            double res = ds.Average(DataTable, 3);
            double wait = 11343224.2;
            Assert.AreEqual(res, wait);
        }
    }
}
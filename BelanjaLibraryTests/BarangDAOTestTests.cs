using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelanjaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelanjaLibrary.Tests
{
    // Membuat Unit Test 
    [TestClass()]
    // Membuat class BarangDAOTest 
    public class BarangDAOTestTests
    {
            // Membuat objek BarangDAOTest yang bernama DAOTest 
            public BarangDAOTest DAOTest;

            // Membuat constructor BarangDAOTestTests 
            public BarangDAOTestTests()
            {
                DAOTest = new BarangDAOTest();
            }

            [TestMethod()]
            // Membuat Test Penambahan Barang 
            public void AddBarangCountTesting()
            {
                // Membuat List Barang yang bernama test1 
                List<Barang> test1 = new List<Barang>();

                // Membuat tes ada / tidaknya pemasukkan data kedalam List barang test1 
                test1.Add(new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                });
                // Membuat tes ada / tidaknya pemasukkan data kedalam List barang yang dibentuk di BarangDAOTest yang bernama ListBarang 
                DAOTest.Insert(new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                });
                // Jika ada pemasukan ke dalam list, maka count akan berfungsi untuk menghitung jumlah data yang dimasukkan 
                Assert.AreEqual(test1.Count, DAOTest.ListBarang.Count);
            }

            [TestMethod()]
            // ExpectedException merupakan hasil yang diharapkan 
            [ExpectedException(typeof(ArgumentException))]
            // Tes melakukan penambahan angka minus 
            public void AddBarangTestingMin()
            {
                // Tes penginputan angka minus pada harga dan pajak 
                DAOTest.Insert(new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0002",
                    HargaBarang = "-3",
                    PajakBarang = "10"
                });
            }

            [TestMethod()]
            // ExpectedException merupakan hasil yang diharapkan 
            [ExpectedException(typeof(ArgumentException))]
            // Tes melakukan penambahan string pada data harga dan pajak barang 
            public void AddBarangTestingString()
            {
                // Penginputan string pada harga dan pajak 
                DAOTest.Insert(new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0002",
                    HargaBarang = "ss",
                    PajakBarang = "ss"
                });
            }

            [TestMethod()]
            // Tes melakukan update pada suatu barang 
            public void UpdateBarangCountTesting()
            {
                // Tes menyimpan barang ke dalam objek Barang yang bernama lama 
                Barang lama = new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                };
                // Input objek lama ke dalam Listbarang 
                DAOTest.ListBarang.Add(lama);

                // Tes menyimpan barang ke dalam objek Barang yang bernama baru 
                Barang baru = new Barang
                {
                    NamaBarang = "pensil",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"

                };
                // Melakukan update ke baru dari yg lama 
                DAOTest.Update(lama, baru);

                // Membuat List Barang yang bernama Test1 
                List<Barang> Test1 = new List<Barang>();
                // Melakukan input ke dalam list barang test1 
                Test1.Add(new Barang
                {
                    NamaBarang = "pensil",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                });
                // Pengecekan jumlah sebelum dan sesudah update, sama atau tidaknya jumlah 
                Assert.AreEqual(DAOTest.ListBarang.Count, Test1.Count);
            }

            [TestMethod()]
            // ExpectedException merupakan hasil yang diharapkan 
            [ExpectedException(typeof(ArgumentException))]
            // Tes melakukan update dengan angka minus 
            public void UpdateBarangMinTesting()
            {
                // Tes menyimpan barang ke dalam objek Barang yang bernama lama 
                Barang lama = new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                };
                // Input objek lama ke dalam Listbarang 
                DAOTest.ListBarang.Add(lama);

                // Tes menyimpan harga dan pajak barang berisi angka minus ke dalam objek Barang yang bernama baru 
                Barang baru = new Barang
                {
                    NamaBarang = "pensil",
                    KodeBarang = "0001",
                    HargaBarang = "-2",
                    PajakBarang = "10"
                };
                // Melakukan update ke baru dari yg lama 
                DAOTest.Update(lama, baru);
            }

            [TestMethod()]
            // ExpectedException merupakan hasil yang diharapkan 
            [ExpectedException(typeof(ArgumentException))]
            // Tes melakukan update dengan string 
            public void UpdateBarangStringTesting()
            {
                // Tes menyimpan data ke dalam objek Barang yang bernama lama 
                Barang lama = new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                };
                // Input objek lama ke dalam ListBarang 
                DAOTest.ListBarang.Add(lama);

                // Tes menyimpan harga dan pajak barang berisi string ke dalam objek Barang yang bernama baru 
                Barang baru = new Barang
                {
                    NamaBarang = "pensil",
                    KodeBarang = "0001",
                    HargaBarang = "10",
                    PajakBarang = "ss"

                };
                // Melakukan update ke baru dari yg lama 
                DAOTest.Update(lama, baru);
            }

            [TestMethod()]
            // Tes melakukan delete barang 
            public void DeleteBarangCountTesting()
            {
                // Tes menyimpan barang ke dalam objek Barang yang bernama lama 
                Barang lama = new Barang
                {
                    NamaBarang = "buku",
                    KodeBarang = "0001",
                    HargaBarang = "20000",
                    PajakBarang = "10"
                };
                // Input objek lama ke dalam ListBarang 
                DAOTest.ListBarang.Add(lama);
                // Delete data barang dari ListBarang 
                DAOTest.DeleteBarang(lama);

                // Membuat List Barang baru dengan nama test untuk mengecek apakah jumlah sama dengan sesudah delete 
                List<Barang> test = new List<Barang>();
                Assert.AreEqual(test.Count, DAOTest.ListBarang.Count);
            }
        }
}
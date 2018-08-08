using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelanjaLibrary
{
    public class BarangDAOTest
    {
        public List<Barang> ListBarang = new List<Barang>();

        Barang barang = new Barang();


        public void Insert(Barang barang)
        {
            try
            {
                int a = Convert.ToInt32(barang.HargaBarang);
                int b = Convert.ToInt32(barang.PajakBarang);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

            if (Convert.ToInt32(barang.HargaBarang) > 0 && Convert.ToInt32(barang.PajakBarang) >= 0)
            {

                ListBarang.Add(barang);
            }
            else
            {
                throw new ArgumentException();
            }

        }

        public bool DeleteBarang(Barang barang)
        {
            bool result = false;
            try
            {
                if (ItemIsExist(barang))
                {
                    Barang addrToDelete = null;
                    for (int i = 0; i < ListBarang.Count; i++)
                    {
                        addrToDelete = ListBarang[i];
                        if (addrToDelete.NamaBarang.ToLower().Trim().Equals(barang.NamaBarang.ToLower().Trim())
                            )
                        {
                            break;
                        }
                    }
                    if (addrToDelete != null) ListBarang.Remove(addrToDelete);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



        public bool Update(Barang lama, Barang baru)
        {
            try
            {
                int a = Convert.ToInt32(baru.HargaBarang);
                int b = Convert.ToInt32(baru.PajakBarang);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
            bool result = false;
            if (Convert.ToInt32(baru.HargaBarang) > 0 && Convert.ToInt32(baru.PajakBarang) >= 0)
            {
                try
                {
                    if (ItemIsExist(lama))
                    {
                        for (int i = 0; i < ListBarang.Count; i++)
                        {
                            Barang item = ListBarang[i];
                            if (item.KodeBarang.ToLower().Trim().Equals(lama.KodeBarang.ToLower().Trim()))
                            {
                                ListBarang[i] = baru;
                                result = true;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }
        public bool ItemIsExist(Barang barang)
        {
            if (ListBarang?.Count > 0)
            {
                foreach (Barang item in ListBarang)
                {
                    if (item.NamaBarang.ToLower().Trim().Equals(barang.NamaBarang.ToLower().Trim())
                           )
                        return true;
                }
            }
            return false;
        }
    }
}

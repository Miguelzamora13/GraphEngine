using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace storage6
{
    public class storage6
    {
        public static int tcase = 0;
		private static void StorageSavedHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Save Finished.");
            return;
        }
        private static void StorageBeforeSaveHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Save Started.");
            return;
        }
        private static void StorageLoadedHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Load Finished.");
            return;
        }
        private static void StorageBeforeLoadHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Load Started.");
            return;
        }
        private static void StorageResetHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Reset Finished.");
            return;
        }
        private static void StorageBeforeResetHandler()
        {
            storage6.tcase++;
            Console.WriteLine("Reset Started.");
            return;
        }

		[Fact]
        public unsafe void T1()
        {
            Global.LocalStorage.StorageBeforeLoad += StorageBeforeLoadHandler;
            Global.LocalStorage.StorageLoaded += StorageLoadedHandler;
            Global.LocalStorage.LoadStorage();
            Assert.Equal(2, storage6.tcase);

            Global.LocalStorage.StorageBeforeReset += StorageBeforeResetHandler;
            Global.LocalStorage.StorageReset += StorageResetHandler;
            Global.LocalStorage.ResetStorage();
            Assert.Equal(4, storage6.tcase);

            Global.LocalStorage.StorageBeforeSave += StorageBeforeSaveHandler;
            Global.LocalStorage.StorageSaved += StorageSavedHandler;
            Global.LocalStorage.SaveStorage();
            Assert.Equal(6, storage6.tcase);
        }
    }
}

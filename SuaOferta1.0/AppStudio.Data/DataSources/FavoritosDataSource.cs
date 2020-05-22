using System;
using System.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class FavoritosDataSource : DataSourceBase<FavoritosSchema>
    {
        private const string _appId = "273701b5-211a-45de-9e22-6c8f42689220";
        private const string _dataSourceName = "bdcfff41-3f9e-4685-8947-3a8ed407402c";

        protected override string CacheKey
        {
            get { return "FavoritosDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<FavoritosSchema>> LoadDataAsync()
        {
            try
            {
                var serviceDataProvider = new ServiceDataProvider(_appId, _dataSourceName);
                return await serviceDataProvider.Load<FavoritosSchema>();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("FavoritosDataSource.LoadData", ex.ToString());
                return new FavoritosSchema[0];
            }
        }
    }
}

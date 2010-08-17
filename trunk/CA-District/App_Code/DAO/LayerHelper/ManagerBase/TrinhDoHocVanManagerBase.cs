




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TrinhDoHocVanManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class TrinhDoHocVanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhDoHocVanManagerBase()
		{
			// Nothing for now.
		}
		
		public TrinhDoHocVanEntity Insert(TrinhDoHocVanEntity _TrinhDoHocVanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TrinhDoHocVanEntity, true);
			}
			return _TrinhDoHocVanEntity;
		}

		
		public TrinhDoHocVanEntity Insert(Guid Id, string TenTrinhDoHocVan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TrinhDoHocVanEntity _TrinhDoHocVanEntity = new TrinhDoHocVanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TrinhDoHocVanEntity.Id = Id;
				_TrinhDoHocVanEntity.TenTrinhDoHocVan = TenTrinhDoHocVan;
				_TrinhDoHocVanEntity.MaRutGon = MaRutGon;
				_TrinhDoHocVanEntity.MaTp = MaTp;
				_TrinhDoHocVanEntity.GhiChu = GhiChu;
				_TrinhDoHocVanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TrinhDoHocVanEntity.IdNguoiTao = IdNguoiTao;
				_TrinhDoHocVanEntity.NgayTao = NgayTao;
				_TrinhDoHocVanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TrinhDoHocVanEntity.NgayCapNhat = NgayCapNhat;
				_TrinhDoHocVanEntity.NgayHetHan = NgayHetHan;
				_TrinhDoHocVanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TrinhDoHocVanEntity, true);
			}
			return _TrinhDoHocVanEntity;
		}

		public TrinhDoHocVanEntity Insert(string TenTrinhDoHocVan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TrinhDoHocVanEntity _TrinhDoHocVanEntity = new TrinhDoHocVanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TrinhDoHocVanEntity.TenTrinhDoHocVan = TenTrinhDoHocVan;
				_TrinhDoHocVanEntity.MaRutGon = MaRutGon;
				_TrinhDoHocVanEntity.MaTp = MaTp;
				_TrinhDoHocVanEntity.GhiChu = GhiChu;
				_TrinhDoHocVanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TrinhDoHocVanEntity.IdNguoiTao = IdNguoiTao;
				_TrinhDoHocVanEntity.NgayTao = NgayTao;
				_TrinhDoHocVanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TrinhDoHocVanEntity.NgayCapNhat = NgayCapNhat;
				_TrinhDoHocVanEntity.NgayHetHan = NgayHetHan;
				_TrinhDoHocVanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TrinhDoHocVanEntity, true);
			}
			return _TrinhDoHocVanEntity;
		}

		public bool Update(TrinhDoHocVanEntity _TrinhDoHocVanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TrinhDoHocVanFields.Id == _TrinhDoHocVanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TrinhDoHocVanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TrinhDoHocVanEntity _TrinhDoHocVanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TrinhDoHocVanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTrinhDoHocVan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TrinhDoHocVanEntity _TrinhDoHocVanEntity = new TrinhDoHocVanEntity(Id);
				if (adapter.FetchEntity(_TrinhDoHocVanEntity))
				{
				
					_TrinhDoHocVanEntity.TenTrinhDoHocVan = TenTrinhDoHocVan;
					_TrinhDoHocVanEntity.MaRutGon = MaRutGon;
					_TrinhDoHocVanEntity.MaTp = MaTp;
					_TrinhDoHocVanEntity.GhiChu = GhiChu;
					_TrinhDoHocVanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TrinhDoHocVanEntity.IdNguoiTao = IdNguoiTao;
					_TrinhDoHocVanEntity.NgayTao = NgayTao;
					_TrinhDoHocVanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TrinhDoHocVanEntity.NgayCapNhat = NgayCapNhat;
					_TrinhDoHocVanEntity.NgayHetHan = NgayHetHan;
					_TrinhDoHocVanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TrinhDoHocVanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TrinhDoHocVanEntity _TrinhDoHocVanEntity = new TrinhDoHocVanEntity(Id);
				if (adapter.FetchEntity(_TrinhDoHocVanEntity))
				{
					adapter.DeleteEntity(_TrinhDoHocVanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTrinhDoHocVan(string TenTrinhDoHocVan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TenTrinhDoHocVan == TenTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhDoHocVanEntity", filter);
			}
			return toReturn;
		}
		

		
		public TrinhDoHocVanEntity SelectOne(Guid Id)
		{
			TrinhDoHocVanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TrinhDoHocVanEntity _TrinhDoHocVanEntity = new TrinhDoHocVanEntity(Id);
				if (adapter.FetchEntity(_TrinhDoHocVanEntity))
				{
					toReturn = _TrinhDoHocVanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectAllLST()
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, null, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByTenTrinhDoHocVanLST(string TenTrinhDoHocVan)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TenTrinhDoHocVan == TenTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByTenTrinhDoHocVanLST_Paged(string TenTrinhDoHocVan, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TenTrinhDoHocVan == TenTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTrinhDoHocVanRDT(string TenTrinhDoHocVan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TenTrinhDoHocVan == TenTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTrinhDoHocVanRDT_Paged(string TenTrinhDoHocVan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TenTrinhDoHocVan == TenTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return EntityCollection<TrinhDoHocVanEntity>
		public EntityCollection<TrinhDoHocVanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhDoHocVanEntity> _TrinhDoHocVanCollection = new EntityCollection<TrinhDoHocVanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhDoHocVanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhDoHocVanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhDoHocVanCollection = new EntityCollection(new TrinhDoHocVanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhDoHocVanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhDoHocVanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

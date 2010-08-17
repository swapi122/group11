




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TrinhSatBaoCaoManagerBase
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
	public class TrinhSatBaoCaoManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TrinhSatBaoCaoManagerBase()
		{
			// Nothing for now.
		}
		
		public TrinhSatBaoCaoEntity Insert(TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TrinhSatBaoCaoEntity, true);
			}
			return _TrinhSatBaoCaoEntity;
		}

		
		public TrinhSatBaoCaoEntity Insert(Guid Id, string TenTrinhSatBaoCao, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity = new TrinhSatBaoCaoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TrinhSatBaoCaoEntity.Id = Id;
				_TrinhSatBaoCaoEntity.TenTrinhSatBaoCao = TenTrinhSatBaoCao;
				_TrinhSatBaoCaoEntity.MaRutGon = MaRutGon;
				_TrinhSatBaoCaoEntity.MaTp = MaTp;
				_TrinhSatBaoCaoEntity.GhiChu = GhiChu;
				_TrinhSatBaoCaoEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TrinhSatBaoCaoEntity.IdNguoiTao = IdNguoiTao;
				_TrinhSatBaoCaoEntity.NgayTao = NgayTao;
				_TrinhSatBaoCaoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TrinhSatBaoCaoEntity.NgayCapNhat = NgayCapNhat;
				_TrinhSatBaoCaoEntity.NgayHetHan = NgayHetHan;
				_TrinhSatBaoCaoEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TrinhSatBaoCaoEntity, true);
			}
			return _TrinhSatBaoCaoEntity;
		}

		public TrinhSatBaoCaoEntity Insert(string TenTrinhSatBaoCao, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity = new TrinhSatBaoCaoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TrinhSatBaoCaoEntity.TenTrinhSatBaoCao = TenTrinhSatBaoCao;
				_TrinhSatBaoCaoEntity.MaRutGon = MaRutGon;
				_TrinhSatBaoCaoEntity.MaTp = MaTp;
				_TrinhSatBaoCaoEntity.GhiChu = GhiChu;
				_TrinhSatBaoCaoEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TrinhSatBaoCaoEntity.IdNguoiTao = IdNguoiTao;
				_TrinhSatBaoCaoEntity.NgayTao = NgayTao;
				_TrinhSatBaoCaoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TrinhSatBaoCaoEntity.NgayCapNhat = NgayCapNhat;
				_TrinhSatBaoCaoEntity.NgayHetHan = NgayHetHan;
				_TrinhSatBaoCaoEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TrinhSatBaoCaoEntity, true);
			}
			return _TrinhSatBaoCaoEntity;
		}

		public bool Update(TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == _TrinhSatBaoCaoEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TrinhSatBaoCaoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TrinhSatBaoCaoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTrinhSatBaoCao, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity = new TrinhSatBaoCaoEntity(Id);
				if (adapter.FetchEntity(_TrinhSatBaoCaoEntity))
				{
				
					_TrinhSatBaoCaoEntity.TenTrinhSatBaoCao = TenTrinhSatBaoCao;
					_TrinhSatBaoCaoEntity.MaRutGon = MaRutGon;
					_TrinhSatBaoCaoEntity.MaTp = MaTp;
					_TrinhSatBaoCaoEntity.GhiChu = GhiChu;
					_TrinhSatBaoCaoEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TrinhSatBaoCaoEntity.IdNguoiTao = IdNguoiTao;
					_TrinhSatBaoCaoEntity.NgayTao = NgayTao;
					_TrinhSatBaoCaoEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TrinhSatBaoCaoEntity.NgayCapNhat = NgayCapNhat;
					_TrinhSatBaoCaoEntity.NgayHetHan = NgayHetHan;
					_TrinhSatBaoCaoEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TrinhSatBaoCaoEntity, true);
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
				TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity = new TrinhSatBaoCaoEntity(Id);
				if (adapter.FetchEntity(_TrinhSatBaoCaoEntity))
				{
					adapter.DeleteEntity(_TrinhSatBaoCaoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTrinhSatBaoCao(string TenTrinhSatBaoCao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TenTrinhSatBaoCao == TenTrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TrinhSatBaoCaoEntity", filter);
			}
			return toReturn;
		}
		

		
		public TrinhSatBaoCaoEntity SelectOne(Guid Id)
		{
			TrinhSatBaoCaoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TrinhSatBaoCaoEntity _TrinhSatBaoCaoEntity = new TrinhSatBaoCaoEntity(Id);
				if (adapter.FetchEntity(_TrinhSatBaoCaoEntity))
				{
					toReturn = _TrinhSatBaoCaoEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectAllLST()
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, null, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByTenTrinhSatBaoCaoLST(string TenTrinhSatBaoCao)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TenTrinhSatBaoCao == TenTrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByTenTrinhSatBaoCaoLST_Paged(string TenTrinhSatBaoCao, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TenTrinhSatBaoCao == TenTrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTrinhSatBaoCaoRDT(string TenTrinhSatBaoCao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TenTrinhSatBaoCao == TenTrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTrinhSatBaoCaoRDT_Paged(string TenTrinhSatBaoCao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TenTrinhSatBaoCao == TenTrinhSatBaoCao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return EntityCollection<TrinhSatBaoCaoEntity>
		public EntityCollection<TrinhSatBaoCaoEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TrinhSatBaoCaoEntity> _TrinhSatBaoCaoCollection = new EntityCollection<TrinhSatBaoCaoEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TrinhSatBaoCaoCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TrinhSatBaoCaoCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TrinhSatBaoCaoCollection = new EntityCollection(new TrinhSatBaoCaoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TrinhSatBaoCaoFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TrinhSatBaoCaoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

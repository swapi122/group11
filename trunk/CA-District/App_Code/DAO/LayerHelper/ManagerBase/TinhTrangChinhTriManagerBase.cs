




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangChinhTriManagerBase
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
	public class TinhTrangChinhTriManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangChinhTriManagerBase()
		{
			// Nothing for now.
		}
		
		public TinhTrangChinhTriEntity Insert(TinhTrangChinhTriEntity _TinhTrangChinhTriEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TinhTrangChinhTriEntity, true);
			}
			return _TinhTrangChinhTriEntity;
		}

		
		public TinhTrangChinhTriEntity Insert(Guid Id, string TenTinhTrangChinhTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangChinhTriEntity _TinhTrangChinhTriEntity = new TinhTrangChinhTriEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangChinhTriEntity.Id = Id;
				_TinhTrangChinhTriEntity.TenTinhTrangChinhTri = TenTinhTrangChinhTri;
				_TinhTrangChinhTriEntity.MaRutGon = MaRutGon;
				_TinhTrangChinhTriEntity.MaTp = MaTp;
				_TinhTrangChinhTriEntity.GhiChu = GhiChu;
				_TinhTrangChinhTriEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangChinhTriEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangChinhTriEntity.NgayTao = NgayTao;
				_TinhTrangChinhTriEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangChinhTriEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangChinhTriEntity.NgayHetHan = NgayHetHan;
				_TinhTrangChinhTriEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangChinhTriEntity, true);
			}
			return _TinhTrangChinhTriEntity;
		}

		public TinhTrangChinhTriEntity Insert(string TenTinhTrangChinhTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangChinhTriEntity _TinhTrangChinhTriEntity = new TinhTrangChinhTriEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangChinhTriEntity.TenTinhTrangChinhTri = TenTinhTrangChinhTri;
				_TinhTrangChinhTriEntity.MaRutGon = MaRutGon;
				_TinhTrangChinhTriEntity.MaTp = MaTp;
				_TinhTrangChinhTriEntity.GhiChu = GhiChu;
				_TinhTrangChinhTriEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangChinhTriEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangChinhTriEntity.NgayTao = NgayTao;
				_TinhTrangChinhTriEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangChinhTriEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangChinhTriEntity.NgayHetHan = NgayHetHan;
				_TinhTrangChinhTriEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangChinhTriEntity, true);
			}
			return _TinhTrangChinhTriEntity;
		}

		public bool Update(TinhTrangChinhTriEntity _TinhTrangChinhTriEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TinhTrangChinhTriFields.Id == _TinhTrangChinhTriEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TinhTrangChinhTriEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TinhTrangChinhTriEntity _TinhTrangChinhTriEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TinhTrangChinhTriEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTinhTrangChinhTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangChinhTriEntity _TinhTrangChinhTriEntity = new TinhTrangChinhTriEntity(Id);
				if (adapter.FetchEntity(_TinhTrangChinhTriEntity))
				{
				
					_TinhTrangChinhTriEntity.TenTinhTrangChinhTri = TenTinhTrangChinhTri;
					_TinhTrangChinhTriEntity.MaRutGon = MaRutGon;
					_TinhTrangChinhTriEntity.MaTp = MaTp;
					_TinhTrangChinhTriEntity.GhiChu = GhiChu;
					_TinhTrangChinhTriEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TinhTrangChinhTriEntity.IdNguoiTao = IdNguoiTao;
					_TinhTrangChinhTriEntity.NgayTao = NgayTao;
					_TinhTrangChinhTriEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TinhTrangChinhTriEntity.NgayCapNhat = NgayCapNhat;
					_TinhTrangChinhTriEntity.NgayHetHan = NgayHetHan;
					_TinhTrangChinhTriEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TinhTrangChinhTriEntity, true);
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
				TinhTrangChinhTriEntity _TinhTrangChinhTriEntity = new TinhTrangChinhTriEntity(Id);
				if (adapter.FetchEntity(_TinhTrangChinhTriEntity))
				{
					adapter.DeleteEntity(_TinhTrangChinhTriEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTinhTrangChinhTri(string TenTinhTrangChinhTri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TenTinhTrangChinhTri == TenTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangChinhTriEntity", filter);
			}
			return toReturn;
		}
		

		
		public TinhTrangChinhTriEntity SelectOne(Guid Id)
		{
			TinhTrangChinhTriEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangChinhTriEntity _TinhTrangChinhTriEntity = new TinhTrangChinhTriEntity(Id);
				if (adapter.FetchEntity(_TinhTrangChinhTriEntity))
				{
					toReturn = _TinhTrangChinhTriEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectAllLST()
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, null, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByTenTinhTrangChinhTriLST(string TenTinhTrangChinhTri)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TenTinhTrangChinhTri == TenTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByTenTinhTrangChinhTriLST_Paged(string TenTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TenTinhTrangChinhTri == TenTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangChinhTriRDT(string TenTinhTrangChinhTri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TenTinhTrangChinhTri == TenTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangChinhTriRDT_Paged(string TenTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TenTinhTrangChinhTri == TenTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return EntityCollection<TinhTrangChinhTriEntity>
		public EntityCollection<TinhTrangChinhTriEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangChinhTriEntity> _TinhTrangChinhTriCollection = new EntityCollection<TinhTrangChinhTriEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangChinhTriCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangChinhTriCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangChinhTriCollection = new EntityCollection(new TinhTrangChinhTriEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangChinhTriFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangChinhTriCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

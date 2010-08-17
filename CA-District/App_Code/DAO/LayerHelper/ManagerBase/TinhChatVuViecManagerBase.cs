




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhChatVuViecManagerBase
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
	public class TinhChatVuViecManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhChatVuViecManagerBase()
		{
			// Nothing for now.
		}
		
		public TinhChatVuViecEntity Insert(TinhChatVuViecEntity _TinhChatVuViecEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TinhChatVuViecEntity, true);
			}
			return _TinhChatVuViecEntity;
		}

		
		public TinhChatVuViecEntity Insert(Guid Id, string TenTinhChatVuViec, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhChatVuViecEntity _TinhChatVuViecEntity = new TinhChatVuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhChatVuViecEntity.Id = Id;
				_TinhChatVuViecEntity.TenTinhChatVuViec = TenTinhChatVuViec;
				_TinhChatVuViecEntity.MaRutGon = MaRutGon;
				_TinhChatVuViecEntity.MaTp = MaTp;
				_TinhChatVuViecEntity.GhiChu = GhiChu;
				_TinhChatVuViecEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhChatVuViecEntity.IdNguoiTao = IdNguoiTao;
				_TinhChatVuViecEntity.NgayTao = NgayTao;
				_TinhChatVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhChatVuViecEntity.NgayCapNhat = NgayCapNhat;
				_TinhChatVuViecEntity.NgayHetHan = NgayHetHan;
				_TinhChatVuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhChatVuViecEntity, true);
			}
			return _TinhChatVuViecEntity;
		}

		public TinhChatVuViecEntity Insert(string TenTinhChatVuViec, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhChatVuViecEntity _TinhChatVuViecEntity = new TinhChatVuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhChatVuViecEntity.TenTinhChatVuViec = TenTinhChatVuViec;
				_TinhChatVuViecEntity.MaRutGon = MaRutGon;
				_TinhChatVuViecEntity.MaTp = MaTp;
				_TinhChatVuViecEntity.GhiChu = GhiChu;
				_TinhChatVuViecEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhChatVuViecEntity.IdNguoiTao = IdNguoiTao;
				_TinhChatVuViecEntity.NgayTao = NgayTao;
				_TinhChatVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhChatVuViecEntity.NgayCapNhat = NgayCapNhat;
				_TinhChatVuViecEntity.NgayHetHan = NgayHetHan;
				_TinhChatVuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhChatVuViecEntity, true);
			}
			return _TinhChatVuViecEntity;
		}

		public bool Update(TinhChatVuViecEntity _TinhChatVuViecEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TinhChatVuViecFields.Id == _TinhChatVuViecEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TinhChatVuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TinhChatVuViecEntity _TinhChatVuViecEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TinhChatVuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTinhChatVuViec, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhChatVuViecEntity _TinhChatVuViecEntity = new TinhChatVuViecEntity(Id);
				if (adapter.FetchEntity(_TinhChatVuViecEntity))
				{
				
					_TinhChatVuViecEntity.TenTinhChatVuViec = TenTinhChatVuViec;
					_TinhChatVuViecEntity.MaRutGon = MaRutGon;
					_TinhChatVuViecEntity.MaTp = MaTp;
					_TinhChatVuViecEntity.GhiChu = GhiChu;
					_TinhChatVuViecEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TinhChatVuViecEntity.IdNguoiTao = IdNguoiTao;
					_TinhChatVuViecEntity.NgayTao = NgayTao;
					_TinhChatVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TinhChatVuViecEntity.NgayCapNhat = NgayCapNhat;
					_TinhChatVuViecEntity.NgayHetHan = NgayHetHan;
					_TinhChatVuViecEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TinhChatVuViecEntity, true);
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
				TinhChatVuViecEntity _TinhChatVuViecEntity = new TinhChatVuViecEntity(Id);
				if (adapter.FetchEntity(_TinhChatVuViecEntity))
				{
					adapter.DeleteEntity(_TinhChatVuViecEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTinhChatVuViec(string TenTinhChatVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TenTinhChatVuViec == TenTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhChatVuViecEntity", filter);
			}
			return toReturn;
		}
		

		
		public TinhChatVuViecEntity SelectOne(Guid Id)
		{
			TinhChatVuViecEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhChatVuViecEntity _TinhChatVuViecEntity = new TinhChatVuViecEntity(Id);
				if (adapter.FetchEntity(_TinhChatVuViecEntity))
				{
					toReturn = _TinhChatVuViecEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectAllLST()
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, null, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByTenTinhChatVuViecLST(string TenTinhChatVuViec)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TenTinhChatVuViec == TenTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByTenTinhChatVuViecLST_Paged(string TenTinhChatVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TenTinhChatVuViec == TenTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhChatVuViecRDT(string TenTinhChatVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TenTinhChatVuViec == TenTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhChatVuViecRDT_Paged(string TenTinhChatVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TenTinhChatVuViec == TenTinhChatVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return EntityCollection<TinhChatVuViecEntity>
		public EntityCollection<TinhChatVuViecEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TinhChatVuViecEntity> _TinhChatVuViecCollection = new EntityCollection<TinhChatVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhChatVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhChatVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhChatVuViecCollection = new EntityCollection(new TinhChatVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhChatVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhChatVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

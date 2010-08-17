




/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiDoiTuongManagerBase
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
	public class LoaiDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public LoaiDoiTuongEntity Insert(LoaiDoiTuongEntity _LoaiDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_LoaiDoiTuongEntity, true);
			}
			return _LoaiDoiTuongEntity;
		}

		
		public LoaiDoiTuongEntity Insert(Guid Id, string TenLoaiDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiDoiTuongEntity _LoaiDoiTuongEntity = new LoaiDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiDoiTuongEntity.Id = Id;
				_LoaiDoiTuongEntity.TenLoaiDoiTuong = TenLoaiDoiTuong;
				_LoaiDoiTuongEntity.MaRutGon = MaRutGon;
				_LoaiDoiTuongEntity.MaTp = MaTp;
				_LoaiDoiTuongEntity.GhiChu = GhiChu;
				_LoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_LoaiDoiTuongEntity.NgayTao = NgayTao;
				_LoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_LoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
				_LoaiDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiDoiTuongEntity, true);
			}
			return _LoaiDoiTuongEntity;
		}

		public LoaiDoiTuongEntity Insert(string TenLoaiDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiDoiTuongEntity _LoaiDoiTuongEntity = new LoaiDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiDoiTuongEntity.TenLoaiDoiTuong = TenLoaiDoiTuong;
				_LoaiDoiTuongEntity.MaRutGon = MaRutGon;
				_LoaiDoiTuongEntity.MaTp = MaTp;
				_LoaiDoiTuongEntity.GhiChu = GhiChu;
				_LoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_LoaiDoiTuongEntity.NgayTao = NgayTao;
				_LoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_LoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
				_LoaiDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiDoiTuongEntity, true);
			}
			return _LoaiDoiTuongEntity;
		}

		public bool Update(LoaiDoiTuongEntity _LoaiDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(LoaiDoiTuongFields.Id == _LoaiDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LoaiDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LoaiDoiTuongEntity _LoaiDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LoaiDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenLoaiDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiDoiTuongEntity _LoaiDoiTuongEntity = new LoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_LoaiDoiTuongEntity))
				{
				
					_LoaiDoiTuongEntity.TenLoaiDoiTuong = TenLoaiDoiTuong;
					_LoaiDoiTuongEntity.MaRutGon = MaRutGon;
					_LoaiDoiTuongEntity.MaTp = MaTp;
					_LoaiDoiTuongEntity.GhiChu = GhiChu;
					_LoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_LoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_LoaiDoiTuongEntity.NgayTao = NgayTao;
					_LoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_LoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_LoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
					_LoaiDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_LoaiDoiTuongEntity, true);
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
				LoaiDoiTuongEntity _LoaiDoiTuongEntity = new LoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_LoaiDoiTuongEntity))
				{
					adapter.DeleteEntity(_LoaiDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenLoaiDoiTuong(string TenLoaiDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TenLoaiDoiTuong == TenLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public LoaiDoiTuongEntity SelectOne(Guid Id)
		{
			LoaiDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiDoiTuongEntity _LoaiDoiTuongEntity = new LoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_LoaiDoiTuongEntity))
				{
					toReturn = _LoaiDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, null, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByTenLoaiDoiTuongLST(string TenLoaiDoiTuong)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TenLoaiDoiTuong == TenLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByTenLoaiDoiTuongLST_Paged(string TenLoaiDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TenLoaiDoiTuong == TenLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiDoiTuongRDT(string TenLoaiDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TenLoaiDoiTuong == TenLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiDoiTuongRDT_Paged(string TenLoaiDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TenLoaiDoiTuong == TenLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<LoaiDoiTuongEntity>
		public EntityCollection<LoaiDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDoiTuongEntity> _LoaiDoiTuongCollection = new EntityCollection<LoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDoiTuongCollection = new EntityCollection(new LoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

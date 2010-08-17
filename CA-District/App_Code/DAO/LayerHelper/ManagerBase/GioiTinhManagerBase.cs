




/*
'===============================================================================
'  LayerHelper.CAQ.BL.GioiTinhManagerBase
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
	public class GioiTinhManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public GioiTinhManagerBase()
		{
			// Nothing for now.
		}
		
		public GioiTinhEntity Insert(GioiTinhEntity _GioiTinhEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_GioiTinhEntity, true);
			}
			return _GioiTinhEntity;
		}

		
		public GioiTinhEntity Insert(Guid Id, string TenGioiTinh, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			GioiTinhEntity _GioiTinhEntity = new GioiTinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_GioiTinhEntity.Id = Id;
				_GioiTinhEntity.TenGioiTinh = TenGioiTinh;
				_GioiTinhEntity.MaRutGon = MaRutGon;
				_GioiTinhEntity.MaTp = MaTp;
				_GioiTinhEntity.GhiChu = GhiChu;
				_GioiTinhEntity.LoaiDanhMuc = LoaiDanhMuc;
				_GioiTinhEntity.IdNguoiTao = IdNguoiTao;
				_GioiTinhEntity.NgayTao = NgayTao;
				_GioiTinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_GioiTinhEntity.NgayCapNhat = NgayCapNhat;
				_GioiTinhEntity.NgayHetHan = NgayHetHan;
				_GioiTinhEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_GioiTinhEntity, true);
			}
			return _GioiTinhEntity;
		}

		public GioiTinhEntity Insert(string TenGioiTinh, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			GioiTinhEntity _GioiTinhEntity = new GioiTinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_GioiTinhEntity.TenGioiTinh = TenGioiTinh;
				_GioiTinhEntity.MaRutGon = MaRutGon;
				_GioiTinhEntity.MaTp = MaTp;
				_GioiTinhEntity.GhiChu = GhiChu;
				_GioiTinhEntity.LoaiDanhMuc = LoaiDanhMuc;
				_GioiTinhEntity.IdNguoiTao = IdNguoiTao;
				_GioiTinhEntity.NgayTao = NgayTao;
				_GioiTinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_GioiTinhEntity.NgayCapNhat = NgayCapNhat;
				_GioiTinhEntity.NgayHetHan = NgayHetHan;
				_GioiTinhEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_GioiTinhEntity, true);
			}
			return _GioiTinhEntity;
		}

		public bool Update(GioiTinhEntity _GioiTinhEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(GioiTinhFields.Id == _GioiTinhEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_GioiTinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(GioiTinhEntity _GioiTinhEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_GioiTinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenGioiTinh, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				GioiTinhEntity _GioiTinhEntity = new GioiTinhEntity(Id);
				if (adapter.FetchEntity(_GioiTinhEntity))
				{
				
					_GioiTinhEntity.TenGioiTinh = TenGioiTinh;
					_GioiTinhEntity.MaRutGon = MaRutGon;
					_GioiTinhEntity.MaTp = MaTp;
					_GioiTinhEntity.GhiChu = GhiChu;
					_GioiTinhEntity.LoaiDanhMuc = LoaiDanhMuc;
					_GioiTinhEntity.IdNguoiTao = IdNguoiTao;
					_GioiTinhEntity.NgayTao = NgayTao;
					_GioiTinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_GioiTinhEntity.NgayCapNhat = NgayCapNhat;
					_GioiTinhEntity.NgayHetHan = NgayHetHan;
					_GioiTinhEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_GioiTinhEntity, true);
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
				GioiTinhEntity _GioiTinhEntity = new GioiTinhEntity(Id);
				if (adapter.FetchEntity(_GioiTinhEntity))
				{
					adapter.DeleteEntity(_GioiTinhEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("GioiTinhEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenGioiTinh(string TenGioiTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TenGioiTinh == TenGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("GioiTinhEntity", filter);
			}
			return toReturn;
		}
		

		
		public GioiTinhEntity SelectOne(Guid Id)
		{
			GioiTinhEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				GioiTinhEntity _GioiTinhEntity = new GioiTinhEntity(Id);
				if (adapter.FetchEntity(_GioiTinhEntity))
				{
					toReturn = _GioiTinhEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectAllLST()
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, null, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByTenGioiTinhLST(string TenGioiTinh)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TenGioiTinh == TenGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByTenGioiTinhLST_Paged(string TenGioiTinh, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TenGioiTinh == TenGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenGioiTinhRDT(string TenGioiTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TenGioiTinh == TenGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenGioiTinhRDT_Paged(string TenGioiTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TenGioiTinh == TenGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null);
			}
			return _GioiTinhCollection;
		}
		
		// Return EntityCollection<GioiTinhEntity>
		public EntityCollection<GioiTinhEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<GioiTinhEntity> _GioiTinhCollection = new EntityCollection<GioiTinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_GioiTinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _GioiTinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _GioiTinhCollection = new EntityCollection(new GioiTinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(GioiTinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_GioiTinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

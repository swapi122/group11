




/*
'===============================================================================
'  LayerHelper.CAQ.BL.NgheNghiepManagerBase
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
	public class NgheNghiepManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepManagerBase()
		{
			// Nothing for now.
		}
		
		public NgheNghiepEntity Insert(NgheNghiepEntity _NgheNghiepEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NgheNghiepEntity, true);
			}
			return _NgheNghiepEntity;
		}

		
		public NgheNghiepEntity Insert(Guid Id, string TenNgheNghiep, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NgheNghiepEntity _NgheNghiepEntity = new NgheNghiepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NgheNghiepEntity.Id = Id;
				_NgheNghiepEntity.TenNgheNghiep = TenNgheNghiep;
				_NgheNghiepEntity.MaRutGon = MaRutGon;
				_NgheNghiepEntity.MaTp = MaTp;
				_NgheNghiepEntity.GhiChu = GhiChu;
				_NgheNghiepEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NgheNghiepEntity.IdNguoiTao = IdNguoiTao;
				_NgheNghiepEntity.NgayTao = NgayTao;
				_NgheNghiepEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NgheNghiepEntity.NgayCapNhat = NgayCapNhat;
				_NgheNghiepEntity.NgayHetHan = NgayHetHan;
				_NgheNghiepEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NgheNghiepEntity, true);
			}
			return _NgheNghiepEntity;
		}

		public NgheNghiepEntity Insert(string TenNgheNghiep, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NgheNghiepEntity _NgheNghiepEntity = new NgheNghiepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NgheNghiepEntity.TenNgheNghiep = TenNgheNghiep;
				_NgheNghiepEntity.MaRutGon = MaRutGon;
				_NgheNghiepEntity.MaTp = MaTp;
				_NgheNghiepEntity.GhiChu = GhiChu;
				_NgheNghiepEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NgheNghiepEntity.IdNguoiTao = IdNguoiTao;
				_NgheNghiepEntity.NgayTao = NgayTao;
				_NgheNghiepEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NgheNghiepEntity.NgayCapNhat = NgayCapNhat;
				_NgheNghiepEntity.NgayHetHan = NgayHetHan;
				_NgheNghiepEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NgheNghiepEntity, true);
			}
			return _NgheNghiepEntity;
		}

		public bool Update(NgheNghiepEntity _NgheNghiepEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NgheNghiepFields.Id == _NgheNghiepEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NgheNghiepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NgheNghiepEntity _NgheNghiepEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NgheNghiepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenNgheNghiep, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NgheNghiepEntity _NgheNghiepEntity = new NgheNghiepEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepEntity))
				{
				
					_NgheNghiepEntity.TenNgheNghiep = TenNgheNghiep;
					_NgheNghiepEntity.MaRutGon = MaRutGon;
					_NgheNghiepEntity.MaTp = MaTp;
					_NgheNghiepEntity.GhiChu = GhiChu;
					_NgheNghiepEntity.LoaiDanhMuc = LoaiDanhMuc;
					_NgheNghiepEntity.IdNguoiTao = IdNguoiTao;
					_NgheNghiepEntity.NgayTao = NgayTao;
					_NgheNghiepEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NgheNghiepEntity.NgayCapNhat = NgayCapNhat;
					_NgheNghiepEntity.NgayHetHan = NgayHetHan;
					_NgheNghiepEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NgheNghiepEntity, true);
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
				NgheNghiepEntity _NgheNghiepEntity = new NgheNghiepEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepEntity))
				{
					adapter.DeleteEntity(_NgheNghiepEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NgheNghiepEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenNgheNghiep(string TenNgheNghiep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TenNgheNghiep == TenNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepEntity", filter);
			}
			return toReturn;
		}
		

		
		public NgheNghiepEntity SelectOne(Guid Id)
		{
			NgheNghiepEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NgheNghiepEntity _NgheNghiepEntity = new NgheNghiepEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepEntity))
				{
					toReturn = _NgheNghiepEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectAllLST()
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, null, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByTenNgheNghiepLST(string TenNgheNghiep)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TenNgheNghiep == TenNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByTenNgheNghiepLST_Paged(string TenNgheNghiep, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TenNgheNghiep == TenNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenNgheNghiepRDT(string TenNgheNghiep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TenNgheNghiep == TenNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenNgheNghiepRDT_Paged(string TenNgheNghiep, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TenNgheNghiep == TenNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null);
			}
			return _NgheNghiepCollection;
		}
		
		// Return EntityCollection<NgheNghiepEntity>
		public EntityCollection<NgheNghiepEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepEntity> _NgheNghiepCollection = new EntityCollection<NgheNghiepEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepCollection = new EntityCollection(new NgheNghiepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

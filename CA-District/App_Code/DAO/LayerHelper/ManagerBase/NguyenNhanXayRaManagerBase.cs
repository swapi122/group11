




/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguyenNhanXayRaManagerBase
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
	public class NguyenNhanXayRaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguyenNhanXayRaManagerBase()
		{
			// Nothing for now.
		}
		
		public NguyenNhanXayRaEntity Insert(NguyenNhanXayRaEntity _NguyenNhanXayRaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NguyenNhanXayRaEntity, true);
			}
			return _NguyenNhanXayRaEntity;
		}

		
		public NguyenNhanXayRaEntity Insert(Guid Id, string TenNguyenNhanXayRa, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NguyenNhanXayRaEntity _NguyenNhanXayRaEntity = new NguyenNhanXayRaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NguyenNhanXayRaEntity.Id = Id;
				_NguyenNhanXayRaEntity.TenNguyenNhanXayRa = TenNguyenNhanXayRa;
				_NguyenNhanXayRaEntity.MaRutGon = MaRutGon;
				_NguyenNhanXayRaEntity.MaTp = MaTp;
				_NguyenNhanXayRaEntity.GhiChu = GhiChu;
				_NguyenNhanXayRaEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NguyenNhanXayRaEntity.IdNguoiTao = IdNguoiTao;
				_NguyenNhanXayRaEntity.NgayTao = NgayTao;
				_NguyenNhanXayRaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NguyenNhanXayRaEntity.NgayCapNhat = NgayCapNhat;
				_NguyenNhanXayRaEntity.NgayHetHan = NgayHetHan;
				_NguyenNhanXayRaEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NguyenNhanXayRaEntity, true);
			}
			return _NguyenNhanXayRaEntity;
		}

		public NguyenNhanXayRaEntity Insert(string TenNguyenNhanXayRa, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NguyenNhanXayRaEntity _NguyenNhanXayRaEntity = new NguyenNhanXayRaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NguyenNhanXayRaEntity.TenNguyenNhanXayRa = TenNguyenNhanXayRa;
				_NguyenNhanXayRaEntity.MaRutGon = MaRutGon;
				_NguyenNhanXayRaEntity.MaTp = MaTp;
				_NguyenNhanXayRaEntity.GhiChu = GhiChu;
				_NguyenNhanXayRaEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NguyenNhanXayRaEntity.IdNguoiTao = IdNguoiTao;
				_NguyenNhanXayRaEntity.NgayTao = NgayTao;
				_NguyenNhanXayRaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NguyenNhanXayRaEntity.NgayCapNhat = NgayCapNhat;
				_NguyenNhanXayRaEntity.NgayHetHan = NgayHetHan;
				_NguyenNhanXayRaEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NguyenNhanXayRaEntity, true);
			}
			return _NguyenNhanXayRaEntity;
		}

		public bool Update(NguyenNhanXayRaEntity _NguyenNhanXayRaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NguyenNhanXayRaFields.Id == _NguyenNhanXayRaEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NguyenNhanXayRaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NguyenNhanXayRaEntity _NguyenNhanXayRaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NguyenNhanXayRaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenNguyenNhanXayRa, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NguyenNhanXayRaEntity _NguyenNhanXayRaEntity = new NguyenNhanXayRaEntity(Id);
				if (adapter.FetchEntity(_NguyenNhanXayRaEntity))
				{
				
					_NguyenNhanXayRaEntity.TenNguyenNhanXayRa = TenNguyenNhanXayRa;
					_NguyenNhanXayRaEntity.MaRutGon = MaRutGon;
					_NguyenNhanXayRaEntity.MaTp = MaTp;
					_NguyenNhanXayRaEntity.GhiChu = GhiChu;
					_NguyenNhanXayRaEntity.LoaiDanhMuc = LoaiDanhMuc;
					_NguyenNhanXayRaEntity.IdNguoiTao = IdNguoiTao;
					_NguyenNhanXayRaEntity.NgayTao = NgayTao;
					_NguyenNhanXayRaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NguyenNhanXayRaEntity.NgayCapNhat = NgayCapNhat;
					_NguyenNhanXayRaEntity.NgayHetHan = NgayHetHan;
					_NguyenNhanXayRaEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NguyenNhanXayRaEntity, true);
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
				NguyenNhanXayRaEntity _NguyenNhanXayRaEntity = new NguyenNhanXayRaEntity(Id);
				if (adapter.FetchEntity(_NguyenNhanXayRaEntity))
				{
					adapter.DeleteEntity(_NguyenNhanXayRaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenNguyenNhanXayRa(string TenNguyenNhanXayRa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TenNguyenNhanXayRa == TenNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguyenNhanXayRaEntity", filter);
			}
			return toReturn;
		}
		

		
		public NguyenNhanXayRaEntity SelectOne(Guid Id)
		{
			NguyenNhanXayRaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NguyenNhanXayRaEntity _NguyenNhanXayRaEntity = new NguyenNhanXayRaEntity(Id);
				if (adapter.FetchEntity(_NguyenNhanXayRaEntity))
				{
					toReturn = _NguyenNhanXayRaEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectAllLST()
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, null, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByTenNguyenNhanXayRaLST(string TenNguyenNhanXayRa)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TenNguyenNhanXayRa == TenNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByTenNguyenNhanXayRaLST_Paged(string TenNguyenNhanXayRa, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TenNguyenNhanXayRa == TenNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenNguyenNhanXayRaRDT(string TenNguyenNhanXayRa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TenNguyenNhanXayRa == TenNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenNguyenNhanXayRaRDT_Paged(string TenNguyenNhanXayRa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TenNguyenNhanXayRa == TenNguyenNhanXayRa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return EntityCollection<NguyenNhanXayRaEntity>
		public EntityCollection<NguyenNhanXayRaEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NguyenNhanXayRaEntity> _NguyenNhanXayRaCollection = new EntityCollection<NguyenNhanXayRaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguyenNhanXayRaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguyenNhanXayRaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguyenNhanXayRaCollection = new EntityCollection(new NguyenNhanXayRaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguyenNhanXayRaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguyenNhanXayRaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

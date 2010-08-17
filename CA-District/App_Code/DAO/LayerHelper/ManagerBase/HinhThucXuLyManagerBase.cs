




/*
'===============================================================================
'  LayerHelper.CAQ.BL.HinhThucXuLyManagerBase
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
	public class HinhThucXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HinhThucXuLyManagerBase()
		{
			// Nothing for now.
		}
		
		public HinhThucXuLyEntity Insert(HinhThucXuLyEntity _HinhThucXuLyEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HinhThucXuLyEntity, true);
			}
			return _HinhThucXuLyEntity;
		}

		
		public HinhThucXuLyEntity Insert(Guid Id, string TenHinhThucXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HinhThucXuLyEntity _HinhThucXuLyEntity = new HinhThucXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HinhThucXuLyEntity.Id = Id;
				_HinhThucXuLyEntity.TenHinhThucXuLy = TenHinhThucXuLy;
				_HinhThucXuLyEntity.MaRutGon = MaRutGon;
				_HinhThucXuLyEntity.MaTp = MaTp;
				_HinhThucXuLyEntity.GhiChu = GhiChu;
				_HinhThucXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
				_HinhThucXuLyEntity.IdNguoiTao = IdNguoiTao;
				_HinhThucXuLyEntity.NgayTao = NgayTao;
				_HinhThucXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HinhThucXuLyEntity.NgayCapNhat = NgayCapNhat;
				_HinhThucXuLyEntity.NgayHetHan = NgayHetHan;
				_HinhThucXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HinhThucXuLyEntity, true);
			}
			return _HinhThucXuLyEntity;
		}

		public HinhThucXuLyEntity Insert(string TenHinhThucXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HinhThucXuLyEntity _HinhThucXuLyEntity = new HinhThucXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HinhThucXuLyEntity.TenHinhThucXuLy = TenHinhThucXuLy;
				_HinhThucXuLyEntity.MaRutGon = MaRutGon;
				_HinhThucXuLyEntity.MaTp = MaTp;
				_HinhThucXuLyEntity.GhiChu = GhiChu;
				_HinhThucXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
				_HinhThucXuLyEntity.IdNguoiTao = IdNguoiTao;
				_HinhThucXuLyEntity.NgayTao = NgayTao;
				_HinhThucXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HinhThucXuLyEntity.NgayCapNhat = NgayCapNhat;
				_HinhThucXuLyEntity.NgayHetHan = NgayHetHan;
				_HinhThucXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HinhThucXuLyEntity, true);
			}
			return _HinhThucXuLyEntity;
		}

		public bool Update(HinhThucXuLyEntity _HinhThucXuLyEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HinhThucXuLyFields.Id == _HinhThucXuLyEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HinhThucXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HinhThucXuLyEntity _HinhThucXuLyEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HinhThucXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenHinhThucXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HinhThucXuLyEntity _HinhThucXuLyEntity = new HinhThucXuLyEntity(Id);
				if (adapter.FetchEntity(_HinhThucXuLyEntity))
				{
				
					_HinhThucXuLyEntity.TenHinhThucXuLy = TenHinhThucXuLy;
					_HinhThucXuLyEntity.MaRutGon = MaRutGon;
					_HinhThucXuLyEntity.MaTp = MaTp;
					_HinhThucXuLyEntity.GhiChu = GhiChu;
					_HinhThucXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
					_HinhThucXuLyEntity.IdNguoiTao = IdNguoiTao;
					_HinhThucXuLyEntity.NgayTao = NgayTao;
					_HinhThucXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_HinhThucXuLyEntity.NgayCapNhat = NgayCapNhat;
					_HinhThucXuLyEntity.NgayHetHan = NgayHetHan;
					_HinhThucXuLyEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_HinhThucXuLyEntity, true);
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
				HinhThucXuLyEntity _HinhThucXuLyEntity = new HinhThucXuLyEntity(Id);
				if (adapter.FetchEntity(_HinhThucXuLyEntity))
				{
					adapter.DeleteEntity(_HinhThucXuLyEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenHinhThucXuLy(string TenHinhThucXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TenHinhThucXuLy == TenHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HinhThucXuLyEntity", filter);
			}
			return toReturn;
		}
		

		
		public HinhThucXuLyEntity SelectOne(Guid Id)
		{
			HinhThucXuLyEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HinhThucXuLyEntity _HinhThucXuLyEntity = new HinhThucXuLyEntity(Id);
				if (adapter.FetchEntity(_HinhThucXuLyEntity))
				{
					toReturn = _HinhThucXuLyEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectAllLST()
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, null, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByTenHinhThucXuLyLST(string TenHinhThucXuLy)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TenHinhThucXuLy == TenHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByTenHinhThucXuLyLST_Paged(string TenHinhThucXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TenHinhThucXuLy == TenHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenHinhThucXuLyRDT(string TenHinhThucXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TenHinhThucXuLy == TenHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenHinhThucXuLyRDT_Paged(string TenHinhThucXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TenHinhThucXuLy == TenHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return EntityCollection<HinhThucXuLyEntity>
		public EntityCollection<HinhThucXuLyEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<HinhThucXuLyEntity> _HinhThucXuLyCollection = new EntityCollection<HinhThucXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HinhThucXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HinhThucXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HinhThucXuLyCollection = new EntityCollection(new HinhThucXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HinhThucXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HinhThucXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.XuLyHanhChinhManagerBase
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
	public class XuLyHanhChinhManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyHanhChinhManagerBase()
		{
			// Nothing for now.
		}
		
		public XuLyHanhChinhEntity Insert(XuLyHanhChinhEntity _XuLyHanhChinhEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_XuLyHanhChinhEntity, true);
			}
			return _XuLyHanhChinhEntity;
		}

		
		public XuLyHanhChinhEntity Insert(Guid Id, string TenXuLyHanhChinh, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XuLyHanhChinhEntity _XuLyHanhChinhEntity = new XuLyHanhChinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuLyHanhChinhEntity.Id = Id;
				_XuLyHanhChinhEntity.TenXuLyHanhChinh = TenXuLyHanhChinh;
				_XuLyHanhChinhEntity.MaRutGon = MaRutGon;
				_XuLyHanhChinhEntity.GhiChu = GhiChu;
				_XuLyHanhChinhEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XuLyHanhChinhEntity.IdNguoiTao = IdNguoiTao;
				_XuLyHanhChinhEntity.NgayTao = NgayTao;
				_XuLyHanhChinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XuLyHanhChinhEntity.NgayCapNhat = NgayCapNhat;
				_XuLyHanhChinhEntity.NgayHetHan = NgayHetHan;
				_XuLyHanhChinhEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XuLyHanhChinhEntity, true);
			}
			return _XuLyHanhChinhEntity;
		}

		public XuLyHanhChinhEntity Insert(string TenXuLyHanhChinh, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XuLyHanhChinhEntity _XuLyHanhChinhEntity = new XuLyHanhChinhEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuLyHanhChinhEntity.TenXuLyHanhChinh = TenXuLyHanhChinh;
				_XuLyHanhChinhEntity.MaRutGon = MaRutGon;
				_XuLyHanhChinhEntity.GhiChu = GhiChu;
				_XuLyHanhChinhEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XuLyHanhChinhEntity.IdNguoiTao = IdNguoiTao;
				_XuLyHanhChinhEntity.NgayTao = NgayTao;
				_XuLyHanhChinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XuLyHanhChinhEntity.NgayCapNhat = NgayCapNhat;
				_XuLyHanhChinhEntity.NgayHetHan = NgayHetHan;
				_XuLyHanhChinhEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XuLyHanhChinhEntity, true);
			}
			return _XuLyHanhChinhEntity;
		}

		public bool Update(XuLyHanhChinhEntity _XuLyHanhChinhEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(XuLyHanhChinhFields.Id == _XuLyHanhChinhEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XuLyHanhChinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XuLyHanhChinhEntity _XuLyHanhChinhEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XuLyHanhChinhEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenXuLyHanhChinh, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuLyHanhChinhEntity _XuLyHanhChinhEntity = new XuLyHanhChinhEntity(Id);
				if (adapter.FetchEntity(_XuLyHanhChinhEntity))
				{
				
					_XuLyHanhChinhEntity.TenXuLyHanhChinh = TenXuLyHanhChinh;
					_XuLyHanhChinhEntity.MaRutGon = MaRutGon;
					_XuLyHanhChinhEntity.GhiChu = GhiChu;
					_XuLyHanhChinhEntity.LoaiDanhMuc = LoaiDanhMuc;
					_XuLyHanhChinhEntity.IdNguoiTao = IdNguoiTao;
					_XuLyHanhChinhEntity.NgayTao = NgayTao;
					_XuLyHanhChinhEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_XuLyHanhChinhEntity.NgayCapNhat = NgayCapNhat;
					_XuLyHanhChinhEntity.NgayHetHan = NgayHetHan;
					_XuLyHanhChinhEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_XuLyHanhChinhEntity, true);
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
				XuLyHanhChinhEntity _XuLyHanhChinhEntity = new XuLyHanhChinhEntity(Id);
				if (adapter.FetchEntity(_XuLyHanhChinhEntity))
				{
					adapter.DeleteEntity(_XuLyHanhChinhEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenXuLyHanhChinh(string TenXuLyHanhChinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TenXuLyHanhChinh == TenXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyHanhChinhEntity", filter);
			}
			return toReturn;
		}
		

		
		public XuLyHanhChinhEntity SelectOne(Guid Id)
		{
			XuLyHanhChinhEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuLyHanhChinhEntity _XuLyHanhChinhEntity = new XuLyHanhChinhEntity(Id);
				if (adapter.FetchEntity(_XuLyHanhChinhEntity))
				{
					toReturn = _XuLyHanhChinhEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectAllLST()
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, null, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByTenXuLyHanhChinhLST(string TenXuLyHanhChinh)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TenXuLyHanhChinh == TenXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByTenXuLyHanhChinhLST_Paged(string TenXuLyHanhChinh, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TenXuLyHanhChinh == TenXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenXuLyHanhChinhRDT(string TenXuLyHanhChinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TenXuLyHanhChinh == TenXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenXuLyHanhChinhRDT_Paged(string TenXuLyHanhChinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TenXuLyHanhChinh == TenXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return EntityCollection<XuLyHanhChinhEntity>
		public EntityCollection<XuLyHanhChinhEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyHanhChinhEntity> _XuLyHanhChinhCollection = new EntityCollection<XuLyHanhChinhEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyHanhChinhCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyHanhChinhCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyHanhChinhCollection = new EntityCollection(new XuLyHanhChinhEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyHanhChinhFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyHanhChinhCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

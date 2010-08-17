




/*
'===============================================================================
'  LayerHelper.CAQ.BL.XuLyDoiTuongManagerBase
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
	public class XuLyDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuLyDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public XuLyDoiTuongEntity Insert(XuLyDoiTuongEntity _XuLyDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_XuLyDoiTuongEntity, true);
			}
			return _XuLyDoiTuongEntity;
		}

		
		public XuLyDoiTuongEntity Insert(Guid Id, string TenXuLyDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XuLyDoiTuongEntity _XuLyDoiTuongEntity = new XuLyDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuLyDoiTuongEntity.Id = Id;
				_XuLyDoiTuongEntity.TenXuLyDoiTuong = TenXuLyDoiTuong;
				_XuLyDoiTuongEntity.MaRutGon = MaRutGon;
				_XuLyDoiTuongEntity.MaTp = MaTp;
				_XuLyDoiTuongEntity.GhiChu = GhiChu;
				_XuLyDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XuLyDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_XuLyDoiTuongEntity.NgayTao = NgayTao;
				_XuLyDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XuLyDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_XuLyDoiTuongEntity.NgayHetHan = NgayHetHan;
				_XuLyDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XuLyDoiTuongEntity, true);
			}
			return _XuLyDoiTuongEntity;
		}

		public XuLyDoiTuongEntity Insert(string TenXuLyDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XuLyDoiTuongEntity _XuLyDoiTuongEntity = new XuLyDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XuLyDoiTuongEntity.TenXuLyDoiTuong = TenXuLyDoiTuong;
				_XuLyDoiTuongEntity.MaRutGon = MaRutGon;
				_XuLyDoiTuongEntity.MaTp = MaTp;
				_XuLyDoiTuongEntity.GhiChu = GhiChu;
				_XuLyDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XuLyDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_XuLyDoiTuongEntity.NgayTao = NgayTao;
				_XuLyDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XuLyDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_XuLyDoiTuongEntity.NgayHetHan = NgayHetHan;
				_XuLyDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XuLyDoiTuongEntity, true);
			}
			return _XuLyDoiTuongEntity;
		}

		public bool Update(XuLyDoiTuongEntity _XuLyDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(XuLyDoiTuongFields.Id == _XuLyDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XuLyDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XuLyDoiTuongEntity _XuLyDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XuLyDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenXuLyDoiTuong, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuLyDoiTuongEntity _XuLyDoiTuongEntity = new XuLyDoiTuongEntity(Id);
				if (adapter.FetchEntity(_XuLyDoiTuongEntity))
				{
				
					_XuLyDoiTuongEntity.TenXuLyDoiTuong = TenXuLyDoiTuong;
					_XuLyDoiTuongEntity.MaRutGon = MaRutGon;
					_XuLyDoiTuongEntity.MaTp = MaTp;
					_XuLyDoiTuongEntity.GhiChu = GhiChu;
					_XuLyDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_XuLyDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_XuLyDoiTuongEntity.NgayTao = NgayTao;
					_XuLyDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_XuLyDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_XuLyDoiTuongEntity.NgayHetHan = NgayHetHan;
					_XuLyDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_XuLyDoiTuongEntity, true);
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
				XuLyDoiTuongEntity _XuLyDoiTuongEntity = new XuLyDoiTuongEntity(Id);
				if (adapter.FetchEntity(_XuLyDoiTuongEntity))
				{
					adapter.DeleteEntity(_XuLyDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenXuLyDoiTuong(string TenXuLyDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TenXuLyDoiTuong == TenXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XuLyDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public XuLyDoiTuongEntity SelectOne(Guid Id)
		{
			XuLyDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XuLyDoiTuongEntity _XuLyDoiTuongEntity = new XuLyDoiTuongEntity(Id);
				if (adapter.FetchEntity(_XuLyDoiTuongEntity))
				{
					toReturn = _XuLyDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, null, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByTenXuLyDoiTuongLST(string TenXuLyDoiTuong)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TenXuLyDoiTuong == TenXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByTenXuLyDoiTuongLST_Paged(string TenXuLyDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TenXuLyDoiTuong == TenXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenXuLyDoiTuongRDT(string TenXuLyDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TenXuLyDoiTuong == TenXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenXuLyDoiTuongRDT_Paged(string TenXuLyDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TenXuLyDoiTuong == TenXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return EntityCollection<XuLyDoiTuongEntity>
		public EntityCollection<XuLyDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<XuLyDoiTuongEntity> _XuLyDoiTuongCollection = new EntityCollection<XuLyDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XuLyDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XuLyDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XuLyDoiTuongCollection = new EntityCollection(new XuLyDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XuLyDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XuLyDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

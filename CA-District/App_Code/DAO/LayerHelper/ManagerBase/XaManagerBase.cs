




/*
'===============================================================================
'  LayerHelper.CAQ.BL.XaManagerBase
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
	public class XaManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XaManagerBase()
		{
			// Nothing for now.
		}
		
		public XaEntity Insert(XaEntity _XaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_XaEntity, true);
			}
			return _XaEntity;
		}

		
		public XaEntity Insert(Guid Id, string TenXa, Guid IdHuyen, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XaEntity _XaEntity = new XaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XaEntity.Id = Id;
				_XaEntity.TenXa = TenXa;
				_XaEntity.IdHuyen = IdHuyen;
				_XaEntity.MaRutGon = MaRutGon;
				_XaEntity.MaTp = MaTp;
				_XaEntity.GhiChu = GhiChu;
				_XaEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XaEntity.IdNguoiTao = IdNguoiTao;
				_XaEntity.NgayTao = NgayTao;
				_XaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XaEntity.NgayCapNhat = NgayCapNhat;
				_XaEntity.NgayHetHan = NgayHetHan;
				_XaEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XaEntity, true);
			}
			return _XaEntity;
		}

		public XaEntity Insert(string TenXa, Guid IdHuyen, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			XaEntity _XaEntity = new XaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_XaEntity.TenXa = TenXa;
				_XaEntity.IdHuyen = IdHuyen;
				_XaEntity.MaRutGon = MaRutGon;
				_XaEntity.MaTp = MaTp;
				_XaEntity.GhiChu = GhiChu;
				_XaEntity.LoaiDanhMuc = LoaiDanhMuc;
				_XaEntity.IdNguoiTao = IdNguoiTao;
				_XaEntity.NgayTao = NgayTao;
				_XaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_XaEntity.NgayCapNhat = NgayCapNhat;
				_XaEntity.NgayHetHan = NgayHetHan;
				_XaEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_XaEntity, true);
			}
			return _XaEntity;
		}

		public bool Update(XaEntity _XaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(XaFields.Id == _XaEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_XaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(XaEntity _XaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_XaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenXa, Guid IdHuyen, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XaEntity _XaEntity = new XaEntity(Id);
				if (adapter.FetchEntity(_XaEntity))
				{
				
					_XaEntity.TenXa = TenXa;
					_XaEntity.IdHuyen = IdHuyen;
					_XaEntity.MaRutGon = MaRutGon;
					_XaEntity.MaTp = MaTp;
					_XaEntity.GhiChu = GhiChu;
					_XaEntity.LoaiDanhMuc = LoaiDanhMuc;
					_XaEntity.IdNguoiTao = IdNguoiTao;
					_XaEntity.NgayTao = NgayTao;
					_XaEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_XaEntity.NgayCapNhat = NgayCapNhat;
					_XaEntity.NgayHetHan = NgayHetHan;
					_XaEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_XaEntity, true);
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
				XaEntity _XaEntity = new XaEntity(Id);
				if (adapter.FetchEntity(_XaEntity))
				{
					adapter.DeleteEntity(_XaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("XaEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenXa(string TenXa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TenXa == TenXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHuyen(Guid IdHuyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("XaEntity", filter);
			}
			return toReturn;
		}
		

		
		public XaEntity SelectOne(Guid Id)
		{
			XaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				XaEntity _XaEntity = new XaEntity(Id);
				if (adapter.FetchEntity(_XaEntity))
				{
					toReturn = _XaEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectAllLST()
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, null, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByTenXaLST(string TenXa)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TenXa == TenXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByTenXaLST_Paged(string TenXa, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TenXa == TenXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenXaRDT(string TenXa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TenXa == TenXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenXaRDT_Paged(string TenXa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TenXa == TenXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdHuyenLST(Guid IdHuyen)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdHuyenLST_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT(Guid IdHuyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null);
			}
			return _XaCollection;
		}
		
		// Return EntityCollection<XaEntity>
		public EntityCollection<XaEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<XaEntity> _XaCollection = new EntityCollection<XaEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_XaCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _XaCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _XaCollection = new EntityCollection(new XaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(XaFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_XaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

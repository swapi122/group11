




/*
'===============================================================================
'  LayerHelper.CAQ.BL.QuyenNhomManagerBase
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
	public class QuyenNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyenNhomManagerBase()
		{
			// Nothing for now.
		}
		
		public QuyenNhomEntity Insert(QuyenNhomEntity _QuyenNhomEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_QuyenNhomEntity, true);
			}
			return _QuyenNhomEntity;
		}

		
		public QuyenNhomEntity Insert(Guid Id, Guid IdNhom, string TenBang, string TenCot, string GiaTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			QuyenNhomEntity _QuyenNhomEntity = new QuyenNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_QuyenNhomEntity.Id = Id;
				_QuyenNhomEntity.IdNhom = IdNhom;
				_QuyenNhomEntity.TenBang = TenBang;
				_QuyenNhomEntity.TenCot = TenCot;
				_QuyenNhomEntity.GiaTri = GiaTri;
				_QuyenNhomEntity.MaRutGon = MaRutGon;
				_QuyenNhomEntity.MaTp = MaTp;
				_QuyenNhomEntity.GhiChu = GhiChu;
				_QuyenNhomEntity.LoaiDanhMuc = LoaiDanhMuc;
				_QuyenNhomEntity.IdNguoiTao = IdNguoiTao;
				_QuyenNhomEntity.NgayTao = NgayTao;
				_QuyenNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_QuyenNhomEntity.NgayCapNhat = NgayCapNhat;
				_QuyenNhomEntity.NgayHetHan = NgayHetHan;
				_QuyenNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_QuyenNhomEntity, true);
			}
			return _QuyenNhomEntity;
		}

		public QuyenNhomEntity Insert(Guid IdNhom, string TenBang, string TenCot, string GiaTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			QuyenNhomEntity _QuyenNhomEntity = new QuyenNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_QuyenNhomEntity.IdNhom = IdNhom;
				_QuyenNhomEntity.TenBang = TenBang;
				_QuyenNhomEntity.TenCot = TenCot;
				_QuyenNhomEntity.GiaTri = GiaTri;
				_QuyenNhomEntity.MaRutGon = MaRutGon;
				_QuyenNhomEntity.MaTp = MaTp;
				_QuyenNhomEntity.GhiChu = GhiChu;
				_QuyenNhomEntity.LoaiDanhMuc = LoaiDanhMuc;
				_QuyenNhomEntity.IdNguoiTao = IdNguoiTao;
				_QuyenNhomEntity.NgayTao = NgayTao;
				_QuyenNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_QuyenNhomEntity.NgayCapNhat = NgayCapNhat;
				_QuyenNhomEntity.NgayHetHan = NgayHetHan;
				_QuyenNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_QuyenNhomEntity, true);
			}
			return _QuyenNhomEntity;
		}

		public bool Update(QuyenNhomEntity _QuyenNhomEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(QuyenNhomFields.Id == _QuyenNhomEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_QuyenNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(QuyenNhomEntity _QuyenNhomEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_QuyenNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdNhom, string TenBang, string TenCot, string GiaTri, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				QuyenNhomEntity _QuyenNhomEntity = new QuyenNhomEntity(Id);
				if (adapter.FetchEntity(_QuyenNhomEntity))
				{
				
					_QuyenNhomEntity.IdNhom = IdNhom;
					_QuyenNhomEntity.TenBang = TenBang;
					_QuyenNhomEntity.TenCot = TenCot;
					_QuyenNhomEntity.GiaTri = GiaTri;
					_QuyenNhomEntity.MaRutGon = MaRutGon;
					_QuyenNhomEntity.MaTp = MaTp;
					_QuyenNhomEntity.GhiChu = GhiChu;
					_QuyenNhomEntity.LoaiDanhMuc = LoaiDanhMuc;
					_QuyenNhomEntity.IdNguoiTao = IdNguoiTao;
					_QuyenNhomEntity.NgayTao = NgayTao;
					_QuyenNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_QuyenNhomEntity.NgayCapNhat = NgayCapNhat;
					_QuyenNhomEntity.NgayHetHan = NgayHetHan;
					_QuyenNhomEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_QuyenNhomEntity, true);
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
				QuyenNhomEntity _QuyenNhomEntity = new QuyenNhomEntity(Id);
				if (adapter.FetchEntity(_QuyenNhomEntity))
				{
					adapter.DeleteEntity(_QuyenNhomEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("QuyenNhomEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNhom(Guid IdNhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenBang(string TenBang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenBang == TenBang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenCot(string TenCot)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenCot == TenCot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGiaTri(string GiaTri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GiaTri == GiaTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyenNhomEntity", filter);
			}
			return toReturn;
		}
		

		
		public QuyenNhomEntity SelectOne(Guid Id)
		{
			QuyenNhomEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				QuyenNhomEntity _QuyenNhomEntity = new QuyenNhomEntity(Id);
				if (adapter.FetchEntity(_QuyenNhomEntity))
				{
					toReturn = _QuyenNhomEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectAllLST()
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, null, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNhomLST(Guid IdNhom)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNhomLST_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT(Guid IdNhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTenBangLST(string TenBang)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenBang == TenBang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTenBangLST_Paged(string TenBang, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenBang == TenBang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenBangRDT(string TenBang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenBang == TenBang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenBangRDT_Paged(string TenBang, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenBang == TenBang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTenCotLST(string TenCot)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenCot == TenCot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTenCotLST_Paged(string TenCot, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenCot == TenCot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenCotRDT(string TenCot)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenCot == TenCot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenCotRDT_Paged(string TenCot, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TenCot == TenCot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByGiaTriLST(string GiaTri)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GiaTri == GiaTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByGiaTriLST_Paged(string GiaTri, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GiaTri == GiaTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriRDT(string GiaTri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GiaTri == GiaTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriRDT_Paged(string GiaTri, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GiaTri == GiaTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null);
			}
			return _QuyenNhomCollection;
		}
		
		// Return EntityCollection<QuyenNhomEntity>
		public EntityCollection<QuyenNhomEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<QuyenNhomEntity> _QuyenNhomCollection = new EntityCollection<QuyenNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyenNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyenNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyenNhomCollection = new EntityCollection(new QuyenNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyenNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyenNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.QuyDinhHinhSuManagerBase
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
	public class QuyDinhHinhSuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public QuyDinhHinhSuManagerBase()
		{
			// Nothing for now.
		}
		
		public QuyDinhHinhSuEntity Insert(QuyDinhHinhSuEntity _QuyDinhHinhSuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_QuyDinhHinhSuEntity, true);
			}
			return _QuyDinhHinhSuEntity;
		}

		
		public QuyDinhHinhSuEntity Insert(Guid Id, string TenQuyDinhHinhSu, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			QuyDinhHinhSuEntity _QuyDinhHinhSuEntity = new QuyDinhHinhSuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_QuyDinhHinhSuEntity.Id = Id;
				_QuyDinhHinhSuEntity.TenQuyDinhHinhSu = TenQuyDinhHinhSu;
				_QuyDinhHinhSuEntity.IdMaCha = IdMaCha;
				_QuyDinhHinhSuEntity.MaRutGon = MaRutGon;
				_QuyDinhHinhSuEntity.MaTp = MaTp;
				_QuyDinhHinhSuEntity.GhiChu = GhiChu;
				_QuyDinhHinhSuEntity.LoaiDanhMuc = LoaiDanhMuc;
				_QuyDinhHinhSuEntity.IdNguoiTao = IdNguoiTao;
				_QuyDinhHinhSuEntity.NgayTao = NgayTao;
				_QuyDinhHinhSuEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_QuyDinhHinhSuEntity.NgayCapNhat = NgayCapNhat;
				_QuyDinhHinhSuEntity.NgayHetHan = NgayHetHan;
				_QuyDinhHinhSuEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_QuyDinhHinhSuEntity, true);
			}
			return _QuyDinhHinhSuEntity;
		}

		public QuyDinhHinhSuEntity Insert(string TenQuyDinhHinhSu, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			QuyDinhHinhSuEntity _QuyDinhHinhSuEntity = new QuyDinhHinhSuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_QuyDinhHinhSuEntity.TenQuyDinhHinhSu = TenQuyDinhHinhSu;
				_QuyDinhHinhSuEntity.IdMaCha = IdMaCha;
				_QuyDinhHinhSuEntity.MaRutGon = MaRutGon;
				_QuyDinhHinhSuEntity.MaTp = MaTp;
				_QuyDinhHinhSuEntity.GhiChu = GhiChu;
				_QuyDinhHinhSuEntity.LoaiDanhMuc = LoaiDanhMuc;
				_QuyDinhHinhSuEntity.IdNguoiTao = IdNguoiTao;
				_QuyDinhHinhSuEntity.NgayTao = NgayTao;
				_QuyDinhHinhSuEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_QuyDinhHinhSuEntity.NgayCapNhat = NgayCapNhat;
				_QuyDinhHinhSuEntity.NgayHetHan = NgayHetHan;
				_QuyDinhHinhSuEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_QuyDinhHinhSuEntity, true);
			}
			return _QuyDinhHinhSuEntity;
		}

		public bool Update(QuyDinhHinhSuEntity _QuyDinhHinhSuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(QuyDinhHinhSuFields.Id == _QuyDinhHinhSuEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_QuyDinhHinhSuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(QuyDinhHinhSuEntity _QuyDinhHinhSuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_QuyDinhHinhSuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenQuyDinhHinhSu, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				QuyDinhHinhSuEntity _QuyDinhHinhSuEntity = new QuyDinhHinhSuEntity(Id);
				if (adapter.FetchEntity(_QuyDinhHinhSuEntity))
				{
				
					_QuyDinhHinhSuEntity.TenQuyDinhHinhSu = TenQuyDinhHinhSu;
					_QuyDinhHinhSuEntity.IdMaCha = IdMaCha;
					_QuyDinhHinhSuEntity.MaRutGon = MaRutGon;
					_QuyDinhHinhSuEntity.MaTp = MaTp;
					_QuyDinhHinhSuEntity.GhiChu = GhiChu;
					_QuyDinhHinhSuEntity.LoaiDanhMuc = LoaiDanhMuc;
					_QuyDinhHinhSuEntity.IdNguoiTao = IdNguoiTao;
					_QuyDinhHinhSuEntity.NgayTao = NgayTao;
					_QuyDinhHinhSuEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_QuyDinhHinhSuEntity.NgayCapNhat = NgayCapNhat;
					_QuyDinhHinhSuEntity.NgayHetHan = NgayHetHan;
					_QuyDinhHinhSuEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_QuyDinhHinhSuEntity, true);
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
				QuyDinhHinhSuEntity _QuyDinhHinhSuEntity = new QuyDinhHinhSuEntity(Id);
				if (adapter.FetchEntity(_QuyDinhHinhSuEntity))
				{
					adapter.DeleteEntity(_QuyDinhHinhSuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenQuyDinhHinhSu(string TenQuyDinhHinhSu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TenQuyDinhHinhSu == TenQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("QuyDinhHinhSuEntity", filter);
			}
			return toReturn;
		}
		

		
		public QuyDinhHinhSuEntity SelectOne(Guid Id)
		{
			QuyDinhHinhSuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				QuyDinhHinhSuEntity _QuyDinhHinhSuEntity = new QuyDinhHinhSuEntity(Id);
				if (adapter.FetchEntity(_QuyDinhHinhSuEntity))
				{
					toReturn = _QuyDinhHinhSuEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectAllLST()
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, null, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByTenQuyDinhHinhSuLST(string TenQuyDinhHinhSu)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TenQuyDinhHinhSu == TenQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByTenQuyDinhHinhSuLST_Paged(string TenQuyDinhHinhSu, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TenQuyDinhHinhSu == TenQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenQuyDinhHinhSuRDT(string TenQuyDinhHinhSu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TenQuyDinhHinhSu == TenQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenQuyDinhHinhSuRDT_Paged(string TenQuyDinhHinhSu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TenQuyDinhHinhSu == TenQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return EntityCollection<QuyDinhHinhSuEntity>
		public EntityCollection<QuyDinhHinhSuEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<QuyDinhHinhSuEntity> _QuyDinhHinhSuCollection = new EntityCollection<QuyDinhHinhSuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_QuyDinhHinhSuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _QuyDinhHinhSuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _QuyDinhHinhSuCollection = new EntityCollection(new QuyDinhHinhSuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(QuyDinhHinhSuFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_QuyDinhHinhSuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

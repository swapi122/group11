




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangBatManagerBase
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
	public class TinhTrangBatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangBatManagerBase()
		{
			// Nothing for now.
		}
		
		public TinhTrangBatEntity Insert(TinhTrangBatEntity _TinhTrangBatEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TinhTrangBatEntity, true);
			}
			return _TinhTrangBatEntity;
		}

		
		public TinhTrangBatEntity Insert(Guid Id, string TenTinhTrangBat, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangBatEntity _TinhTrangBatEntity = new TinhTrangBatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangBatEntity.Id = Id;
				_TinhTrangBatEntity.TenTinhTrangBat = TenTinhTrangBat;
				_TinhTrangBatEntity.IdMaCha = IdMaCha;
				_TinhTrangBatEntity.MaRutGon = MaRutGon;
				_TinhTrangBatEntity.MaTp = MaTp;
				_TinhTrangBatEntity.GhiChu = GhiChu;
				_TinhTrangBatEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangBatEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangBatEntity.NgayTao = NgayTao;
				_TinhTrangBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangBatEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangBatEntity.NgayHetHan = NgayHetHan;
				_TinhTrangBatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangBatEntity, true);
			}
			return _TinhTrangBatEntity;
		}

		public TinhTrangBatEntity Insert(string TenTinhTrangBat, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangBatEntity _TinhTrangBatEntity = new TinhTrangBatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangBatEntity.TenTinhTrangBat = TenTinhTrangBat;
				_TinhTrangBatEntity.IdMaCha = IdMaCha;
				_TinhTrangBatEntity.MaRutGon = MaRutGon;
				_TinhTrangBatEntity.MaTp = MaTp;
				_TinhTrangBatEntity.GhiChu = GhiChu;
				_TinhTrangBatEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangBatEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangBatEntity.NgayTao = NgayTao;
				_TinhTrangBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangBatEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangBatEntity.NgayHetHan = NgayHetHan;
				_TinhTrangBatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangBatEntity, true);
			}
			return _TinhTrangBatEntity;
		}

		public bool Update(TinhTrangBatEntity _TinhTrangBatEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TinhTrangBatFields.Id == _TinhTrangBatEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TinhTrangBatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TinhTrangBatEntity _TinhTrangBatEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TinhTrangBatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTinhTrangBat, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangBatEntity _TinhTrangBatEntity = new TinhTrangBatEntity(Id);
				if (adapter.FetchEntity(_TinhTrangBatEntity))
				{
				
					_TinhTrangBatEntity.TenTinhTrangBat = TenTinhTrangBat;
					_TinhTrangBatEntity.IdMaCha = IdMaCha;
					_TinhTrangBatEntity.MaRutGon = MaRutGon;
					_TinhTrangBatEntity.MaTp = MaTp;
					_TinhTrangBatEntity.GhiChu = GhiChu;
					_TinhTrangBatEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TinhTrangBatEntity.IdNguoiTao = IdNguoiTao;
					_TinhTrangBatEntity.NgayTao = NgayTao;
					_TinhTrangBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TinhTrangBatEntity.NgayCapNhat = NgayCapNhat;
					_TinhTrangBatEntity.NgayHetHan = NgayHetHan;
					_TinhTrangBatEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TinhTrangBatEntity, true);
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
				TinhTrangBatEntity _TinhTrangBatEntity = new TinhTrangBatEntity(Id);
				if (adapter.FetchEntity(_TinhTrangBatEntity))
				{
					adapter.DeleteEntity(_TinhTrangBatEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTinhTrangBat(string TenTinhTrangBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TenTinhTrangBat == TenTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangBatEntity", filter);
			}
			return toReturn;
		}
		

		
		public TinhTrangBatEntity SelectOne(Guid Id)
		{
			TinhTrangBatEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangBatEntity _TinhTrangBatEntity = new TinhTrangBatEntity(Id);
				if (adapter.FetchEntity(_TinhTrangBatEntity))
				{
					toReturn = _TinhTrangBatEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectAllLST()
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, null, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByTenTinhTrangBatLST(string TenTinhTrangBat)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TenTinhTrangBat == TenTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByTenTinhTrangBatLST_Paged(string TenTinhTrangBat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TenTinhTrangBat == TenTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangBatRDT(string TenTinhTrangBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TenTinhTrangBat == TenTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangBatRDT_Paged(string TenTinhTrangBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TenTinhTrangBat == TenTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return EntityCollection<TinhTrangBatEntity>
		public EntityCollection<TinhTrangBatEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangBatEntity> _TinhTrangBatCollection = new EntityCollection<TinhTrangBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangBatCollection = new EntityCollection(new TinhTrangBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

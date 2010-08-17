




/*
'===============================================================================
'  LayerHelper.CAQ.BL.KhoiToVuAnManagerBase
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
	public class KhoiToVuAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KhoiToVuAnManagerBase()
		{
			// Nothing for now.
		}
		
		public KhoiToVuAnEntity Insert(KhoiToVuAnEntity _KhoiToVuAnEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_KhoiToVuAnEntity, true);
			}
			return _KhoiToVuAnEntity;
		}

		
		public KhoiToVuAnEntity Insert(Guid Id, string TenKhoiToVuAn, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			KhoiToVuAnEntity _KhoiToVuAnEntity = new KhoiToVuAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KhoiToVuAnEntity.Id = Id;
				_KhoiToVuAnEntity.TenKhoiToVuAn = TenKhoiToVuAn;
				_KhoiToVuAnEntity.IdMaCha = IdMaCha;
				_KhoiToVuAnEntity.MaRutGon = MaRutGon;
				_KhoiToVuAnEntity.MaTp = MaTp;
				_KhoiToVuAnEntity.GhiChu = GhiChu;
				_KhoiToVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_KhoiToVuAnEntity.IdNguoiTao = IdNguoiTao;
				_KhoiToVuAnEntity.NgayTao = NgayTao;
				_KhoiToVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_KhoiToVuAnEntity.NgayCapNhat = NgayCapNhat;
				_KhoiToVuAnEntity.NgayHetHan = NgayHetHan;
				_KhoiToVuAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_KhoiToVuAnEntity, true);
			}
			return _KhoiToVuAnEntity;
		}

		public KhoiToVuAnEntity Insert(string TenKhoiToVuAn, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			KhoiToVuAnEntity _KhoiToVuAnEntity = new KhoiToVuAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KhoiToVuAnEntity.TenKhoiToVuAn = TenKhoiToVuAn;
				_KhoiToVuAnEntity.IdMaCha = IdMaCha;
				_KhoiToVuAnEntity.MaRutGon = MaRutGon;
				_KhoiToVuAnEntity.MaTp = MaTp;
				_KhoiToVuAnEntity.GhiChu = GhiChu;
				_KhoiToVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_KhoiToVuAnEntity.IdNguoiTao = IdNguoiTao;
				_KhoiToVuAnEntity.NgayTao = NgayTao;
				_KhoiToVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_KhoiToVuAnEntity.NgayCapNhat = NgayCapNhat;
				_KhoiToVuAnEntity.NgayHetHan = NgayHetHan;
				_KhoiToVuAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_KhoiToVuAnEntity, true);
			}
			return _KhoiToVuAnEntity;
		}

		public bool Update(KhoiToVuAnEntity _KhoiToVuAnEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(KhoiToVuAnFields.Id == _KhoiToVuAnEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KhoiToVuAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KhoiToVuAnEntity _KhoiToVuAnEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KhoiToVuAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenKhoiToVuAn, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KhoiToVuAnEntity _KhoiToVuAnEntity = new KhoiToVuAnEntity(Id);
				if (adapter.FetchEntity(_KhoiToVuAnEntity))
				{
				
					_KhoiToVuAnEntity.TenKhoiToVuAn = TenKhoiToVuAn;
					_KhoiToVuAnEntity.IdMaCha = IdMaCha;
					_KhoiToVuAnEntity.MaRutGon = MaRutGon;
					_KhoiToVuAnEntity.MaTp = MaTp;
					_KhoiToVuAnEntity.GhiChu = GhiChu;
					_KhoiToVuAnEntity.LoaiDanhMuc = LoaiDanhMuc;
					_KhoiToVuAnEntity.IdNguoiTao = IdNguoiTao;
					_KhoiToVuAnEntity.NgayTao = NgayTao;
					_KhoiToVuAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_KhoiToVuAnEntity.NgayCapNhat = NgayCapNhat;
					_KhoiToVuAnEntity.NgayHetHan = NgayHetHan;
					_KhoiToVuAnEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_KhoiToVuAnEntity, true);
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
				KhoiToVuAnEntity _KhoiToVuAnEntity = new KhoiToVuAnEntity(Id);
				if (adapter.FetchEntity(_KhoiToVuAnEntity))
				{
					adapter.DeleteEntity(_KhoiToVuAnEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenKhoiToVuAn(string TenKhoiToVuAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TenKhoiToVuAn == TenKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KhoiToVuAnEntity", filter);
			}
			return toReturn;
		}
		

		
		public KhoiToVuAnEntity SelectOne(Guid Id)
		{
			KhoiToVuAnEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KhoiToVuAnEntity _KhoiToVuAnEntity = new KhoiToVuAnEntity(Id);
				if (adapter.FetchEntity(_KhoiToVuAnEntity))
				{
					toReturn = _KhoiToVuAnEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectAllLST()
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, null, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByTenKhoiToVuAnLST(string TenKhoiToVuAn)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TenKhoiToVuAn == TenKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByTenKhoiToVuAnLST_Paged(string TenKhoiToVuAn, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TenKhoiToVuAn == TenKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenKhoiToVuAnRDT(string TenKhoiToVuAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TenKhoiToVuAn == TenKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenKhoiToVuAnRDT_Paged(string TenKhoiToVuAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TenKhoiToVuAn == TenKhoiToVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return EntityCollection<KhoiToVuAnEntity>
		public EntityCollection<KhoiToVuAnEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<KhoiToVuAnEntity> _KhoiToVuAnCollection = new EntityCollection<KhoiToVuAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KhoiToVuAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KhoiToVuAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KhoiToVuAnCollection = new EntityCollection(new KhoiToVuAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KhoiToVuAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KhoiToVuAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

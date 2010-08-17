




/*
'===============================================================================
'  LayerHelper.CAQ.BL.KetQuaXuLyManagerBase
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
	public class KetQuaXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetQuaXuLyManagerBase()
		{
			// Nothing for now.
		}
		
		public KetQuaXuLyEntity Insert(KetQuaXuLyEntity _KetQuaXuLyEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_KetQuaXuLyEntity, true);
			}
			return _KetQuaXuLyEntity;
		}

		
		public KetQuaXuLyEntity Insert(Guid Id, string TenKetQuaXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			KetQuaXuLyEntity _KetQuaXuLyEntity = new KetQuaXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetQuaXuLyEntity.Id = Id;
				_KetQuaXuLyEntity.TenKetQuaXuLy = TenKetQuaXuLy;
				_KetQuaXuLyEntity.MaRutGon = MaRutGon;
				_KetQuaXuLyEntity.MaTp = MaTp;
				_KetQuaXuLyEntity.GhiChu = GhiChu;
				_KetQuaXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
				_KetQuaXuLyEntity.IdNguoiTao = IdNguoiTao;
				_KetQuaXuLyEntity.NgayTao = NgayTao;
				_KetQuaXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_KetQuaXuLyEntity.NgayCapNhat = NgayCapNhat;
				_KetQuaXuLyEntity.NgayHetHan = NgayHetHan;
				_KetQuaXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_KetQuaXuLyEntity, true);
			}
			return _KetQuaXuLyEntity;
		}

		public KetQuaXuLyEntity Insert(string TenKetQuaXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			KetQuaXuLyEntity _KetQuaXuLyEntity = new KetQuaXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetQuaXuLyEntity.TenKetQuaXuLy = TenKetQuaXuLy;
				_KetQuaXuLyEntity.MaRutGon = MaRutGon;
				_KetQuaXuLyEntity.MaTp = MaTp;
				_KetQuaXuLyEntity.GhiChu = GhiChu;
				_KetQuaXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
				_KetQuaXuLyEntity.IdNguoiTao = IdNguoiTao;
				_KetQuaXuLyEntity.NgayTao = NgayTao;
				_KetQuaXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_KetQuaXuLyEntity.NgayCapNhat = NgayCapNhat;
				_KetQuaXuLyEntity.NgayHetHan = NgayHetHan;
				_KetQuaXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_KetQuaXuLyEntity, true);
			}
			return _KetQuaXuLyEntity;
		}

		public bool Update(KetQuaXuLyEntity _KetQuaXuLyEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(KetQuaXuLyFields.Id == _KetQuaXuLyEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetQuaXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetQuaXuLyEntity _KetQuaXuLyEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetQuaXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenKetQuaXuLy, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetQuaXuLyEntity _KetQuaXuLyEntity = new KetQuaXuLyEntity(Id);
				if (adapter.FetchEntity(_KetQuaXuLyEntity))
				{
				
					_KetQuaXuLyEntity.TenKetQuaXuLy = TenKetQuaXuLy;
					_KetQuaXuLyEntity.MaRutGon = MaRutGon;
					_KetQuaXuLyEntity.MaTp = MaTp;
					_KetQuaXuLyEntity.GhiChu = GhiChu;
					_KetQuaXuLyEntity.LoaiDanhMuc = LoaiDanhMuc;
					_KetQuaXuLyEntity.IdNguoiTao = IdNguoiTao;
					_KetQuaXuLyEntity.NgayTao = NgayTao;
					_KetQuaXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_KetQuaXuLyEntity.NgayCapNhat = NgayCapNhat;
					_KetQuaXuLyEntity.NgayHetHan = NgayHetHan;
					_KetQuaXuLyEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_KetQuaXuLyEntity, true);
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
				KetQuaXuLyEntity _KetQuaXuLyEntity = new KetQuaXuLyEntity(Id);
				if (adapter.FetchEntity(_KetQuaXuLyEntity))
				{
					adapter.DeleteEntity(_KetQuaXuLyEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenKetQuaXuLy(string TenKetQuaXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TenKetQuaXuLy == TenKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetQuaXuLyEntity", filter);
			}
			return toReturn;
		}
		

		
		public KetQuaXuLyEntity SelectOne(Guid Id)
		{
			KetQuaXuLyEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetQuaXuLyEntity _KetQuaXuLyEntity = new KetQuaXuLyEntity(Id);
				if (adapter.FetchEntity(_KetQuaXuLyEntity))
				{
					toReturn = _KetQuaXuLyEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectAllLST()
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, null, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByTenKetQuaXuLyLST(string TenKetQuaXuLy)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TenKetQuaXuLy == TenKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByTenKetQuaXuLyLST_Paged(string TenKetQuaXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TenKetQuaXuLy == TenKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenKetQuaXuLyRDT(string TenKetQuaXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TenKetQuaXuLy == TenKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenKetQuaXuLyRDT_Paged(string TenKetQuaXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TenKetQuaXuLy == TenKetQuaXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return EntityCollection<KetQuaXuLyEntity>
		public EntityCollection<KetQuaXuLyEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<KetQuaXuLyEntity> _KetQuaXuLyCollection = new EntityCollection<KetQuaXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetQuaXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _KetQuaXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetQuaXuLyCollection = new EntityCollection(new KetQuaXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetQuaXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetQuaXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

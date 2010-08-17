




/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhuongTienGayAnManagerBase
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
	public class PhuongTienGayAnManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongTienGayAnManagerBase()
		{
			// Nothing for now.
		}
		
		public PhuongTienGayAnEntity Insert(PhuongTienGayAnEntity _PhuongTienGayAnEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PhuongTienGayAnEntity, true);
			}
			return _PhuongTienGayAnEntity;
		}

		
		public PhuongTienGayAnEntity Insert(Guid Id, string TenPhuongTienGayAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhuongTienGayAnEntity _PhuongTienGayAnEntity = new PhuongTienGayAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongTienGayAnEntity.Id = Id;
				_PhuongTienGayAnEntity.TenPhuongTienGayAn = TenPhuongTienGayAn;
				_PhuongTienGayAnEntity.MaRutGon = MaRutGon;
				_PhuongTienGayAnEntity.MaTp = MaTp;
				_PhuongTienGayAnEntity.GhiChu = GhiChu;
				_PhuongTienGayAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhuongTienGayAnEntity.IdNguoiTao = IdNguoiTao;
				_PhuongTienGayAnEntity.NgayTao = NgayTao;
				_PhuongTienGayAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhuongTienGayAnEntity.NgayCapNhat = NgayCapNhat;
				_PhuongTienGayAnEntity.NgayHetHan = NgayHetHan;
				_PhuongTienGayAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhuongTienGayAnEntity, true);
			}
			return _PhuongTienGayAnEntity;
		}

		public PhuongTienGayAnEntity Insert(string TenPhuongTienGayAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhuongTienGayAnEntity _PhuongTienGayAnEntity = new PhuongTienGayAnEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongTienGayAnEntity.TenPhuongTienGayAn = TenPhuongTienGayAn;
				_PhuongTienGayAnEntity.MaRutGon = MaRutGon;
				_PhuongTienGayAnEntity.MaTp = MaTp;
				_PhuongTienGayAnEntity.GhiChu = GhiChu;
				_PhuongTienGayAnEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhuongTienGayAnEntity.IdNguoiTao = IdNguoiTao;
				_PhuongTienGayAnEntity.NgayTao = NgayTao;
				_PhuongTienGayAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhuongTienGayAnEntity.NgayCapNhat = NgayCapNhat;
				_PhuongTienGayAnEntity.NgayHetHan = NgayHetHan;
				_PhuongTienGayAnEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhuongTienGayAnEntity, true);
			}
			return _PhuongTienGayAnEntity;
		}

		public bool Update(PhuongTienGayAnEntity _PhuongTienGayAnEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PhuongTienGayAnFields.Id == _PhuongTienGayAnEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhuongTienGayAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhuongTienGayAnEntity _PhuongTienGayAnEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhuongTienGayAnEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenPhuongTienGayAn, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongTienGayAnEntity _PhuongTienGayAnEntity = new PhuongTienGayAnEntity(Id);
				if (adapter.FetchEntity(_PhuongTienGayAnEntity))
				{
				
					_PhuongTienGayAnEntity.TenPhuongTienGayAn = TenPhuongTienGayAn;
					_PhuongTienGayAnEntity.MaRutGon = MaRutGon;
					_PhuongTienGayAnEntity.MaTp = MaTp;
					_PhuongTienGayAnEntity.GhiChu = GhiChu;
					_PhuongTienGayAnEntity.LoaiDanhMuc = LoaiDanhMuc;
					_PhuongTienGayAnEntity.IdNguoiTao = IdNguoiTao;
					_PhuongTienGayAnEntity.NgayTao = NgayTao;
					_PhuongTienGayAnEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_PhuongTienGayAnEntity.NgayCapNhat = NgayCapNhat;
					_PhuongTienGayAnEntity.NgayHetHan = NgayHetHan;
					_PhuongTienGayAnEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_PhuongTienGayAnEntity, true);
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
				PhuongTienGayAnEntity _PhuongTienGayAnEntity = new PhuongTienGayAnEntity(Id);
				if (adapter.FetchEntity(_PhuongTienGayAnEntity))
				{
					adapter.DeleteEntity(_PhuongTienGayAnEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenPhuongTienGayAn(string TenPhuongTienGayAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TenPhuongTienGayAn == TenPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongTienGayAnEntity", filter);
			}
			return toReturn;
		}
		

		
		public PhuongTienGayAnEntity SelectOne(Guid Id)
		{
			PhuongTienGayAnEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongTienGayAnEntity _PhuongTienGayAnEntity = new PhuongTienGayAnEntity(Id);
				if (adapter.FetchEntity(_PhuongTienGayAnEntity))
				{
					toReturn = _PhuongTienGayAnEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectAllLST()
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, null, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByTenPhuongTienGayAnLST(string TenPhuongTienGayAn)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TenPhuongTienGayAn == TenPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByTenPhuongTienGayAnLST_Paged(string TenPhuongTienGayAn, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TenPhuongTienGayAn == TenPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhuongTienGayAnRDT(string TenPhuongTienGayAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TenPhuongTienGayAn == TenPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhuongTienGayAnRDT_Paged(string TenPhuongTienGayAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TenPhuongTienGayAn == TenPhuongTienGayAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return EntityCollection<PhuongTienGayAnEntity>
		public EntityCollection<PhuongTienGayAnEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongTienGayAnEntity> _PhuongTienGayAnCollection = new EntityCollection<PhuongTienGayAnEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongTienGayAnCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongTienGayAnCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongTienGayAnCollection = new EntityCollection(new PhuongTienGayAnEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongTienGayAnFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongTienGayAnCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

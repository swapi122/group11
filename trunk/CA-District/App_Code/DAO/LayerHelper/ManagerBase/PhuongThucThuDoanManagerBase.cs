




/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhuongThucThuDoanManagerBase
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
	public class PhuongThucThuDoanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhuongThucThuDoanManagerBase()
		{
			// Nothing for now.
		}
		
		public PhuongThucThuDoanEntity Insert(PhuongThucThuDoanEntity _PhuongThucThuDoanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PhuongThucThuDoanEntity, true);
			}
			return _PhuongThucThuDoanEntity;
		}

		
		public PhuongThucThuDoanEntity Insert(Guid Id, string TenPhuongThucThuDoan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhuongThucThuDoanEntity _PhuongThucThuDoanEntity = new PhuongThucThuDoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongThucThuDoanEntity.Id = Id;
				_PhuongThucThuDoanEntity.TenPhuongThucThuDoan = TenPhuongThucThuDoan;
				_PhuongThucThuDoanEntity.MaRutGon = MaRutGon;
				_PhuongThucThuDoanEntity.MaTp = MaTp;
				_PhuongThucThuDoanEntity.GhiChu = GhiChu;
				_PhuongThucThuDoanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhuongThucThuDoanEntity.IdNguoiTao = IdNguoiTao;
				_PhuongThucThuDoanEntity.NgayTao = NgayTao;
				_PhuongThucThuDoanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhuongThucThuDoanEntity.NgayCapNhat = NgayCapNhat;
				_PhuongThucThuDoanEntity.NgayHetHan = NgayHetHan;
				_PhuongThucThuDoanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhuongThucThuDoanEntity, true);
			}
			return _PhuongThucThuDoanEntity;
		}

		public PhuongThucThuDoanEntity Insert(string TenPhuongThucThuDoan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhuongThucThuDoanEntity _PhuongThucThuDoanEntity = new PhuongThucThuDoanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhuongThucThuDoanEntity.TenPhuongThucThuDoan = TenPhuongThucThuDoan;
				_PhuongThucThuDoanEntity.MaRutGon = MaRutGon;
				_PhuongThucThuDoanEntity.MaTp = MaTp;
				_PhuongThucThuDoanEntity.GhiChu = GhiChu;
				_PhuongThucThuDoanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhuongThucThuDoanEntity.IdNguoiTao = IdNguoiTao;
				_PhuongThucThuDoanEntity.NgayTao = NgayTao;
				_PhuongThucThuDoanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhuongThucThuDoanEntity.NgayCapNhat = NgayCapNhat;
				_PhuongThucThuDoanEntity.NgayHetHan = NgayHetHan;
				_PhuongThucThuDoanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhuongThucThuDoanEntity, true);
			}
			return _PhuongThucThuDoanEntity;
		}

		public bool Update(PhuongThucThuDoanEntity _PhuongThucThuDoanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PhuongThucThuDoanFields.Id == _PhuongThucThuDoanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhuongThucThuDoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhuongThucThuDoanEntity _PhuongThucThuDoanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhuongThucThuDoanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenPhuongThucThuDoan, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongThucThuDoanEntity _PhuongThucThuDoanEntity = new PhuongThucThuDoanEntity(Id);
				if (adapter.FetchEntity(_PhuongThucThuDoanEntity))
				{
				
					_PhuongThucThuDoanEntity.TenPhuongThucThuDoan = TenPhuongThucThuDoan;
					_PhuongThucThuDoanEntity.MaRutGon = MaRutGon;
					_PhuongThucThuDoanEntity.MaTp = MaTp;
					_PhuongThucThuDoanEntity.GhiChu = GhiChu;
					_PhuongThucThuDoanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_PhuongThucThuDoanEntity.IdNguoiTao = IdNguoiTao;
					_PhuongThucThuDoanEntity.NgayTao = NgayTao;
					_PhuongThucThuDoanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_PhuongThucThuDoanEntity.NgayCapNhat = NgayCapNhat;
					_PhuongThucThuDoanEntity.NgayHetHan = NgayHetHan;
					_PhuongThucThuDoanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_PhuongThucThuDoanEntity, true);
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
				PhuongThucThuDoanEntity _PhuongThucThuDoanEntity = new PhuongThucThuDoanEntity(Id);
				if (adapter.FetchEntity(_PhuongThucThuDoanEntity))
				{
					adapter.DeleteEntity(_PhuongThucThuDoanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenPhuongThucThuDoan(string TenPhuongThucThuDoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TenPhuongThucThuDoan == TenPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhuongThucThuDoanEntity", filter);
			}
			return toReturn;
		}
		

		
		public PhuongThucThuDoanEntity SelectOne(Guid Id)
		{
			PhuongThucThuDoanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhuongThucThuDoanEntity _PhuongThucThuDoanEntity = new PhuongThucThuDoanEntity(Id);
				if (adapter.FetchEntity(_PhuongThucThuDoanEntity))
				{
					toReturn = _PhuongThucThuDoanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectAllLST()
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, null, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByTenPhuongThucThuDoanLST(string TenPhuongThucThuDoan)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TenPhuongThucThuDoan == TenPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByTenPhuongThucThuDoanLST_Paged(string TenPhuongThucThuDoan, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TenPhuongThucThuDoan == TenPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhuongThucThuDoanRDT(string TenPhuongThucThuDoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TenPhuongThucThuDoan == TenPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhuongThucThuDoanRDT_Paged(string TenPhuongThucThuDoan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TenPhuongThucThuDoan == TenPhuongThucThuDoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return EntityCollection<PhuongThucThuDoanEntity>
		public EntityCollection<PhuongThucThuDoanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<PhuongThucThuDoanEntity> _PhuongThucThuDoanCollection = new EntityCollection<PhuongThucThuDoanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhuongThucThuDoanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhuongThucThuDoanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhuongThucThuDoanCollection = new EntityCollection(new PhuongThucThuDoanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhuongThucThuDoanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhuongThucThuDoanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

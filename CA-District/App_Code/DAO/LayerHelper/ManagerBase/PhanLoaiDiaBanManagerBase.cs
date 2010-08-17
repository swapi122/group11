




/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiDiaBanManagerBase
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
	public class PhanLoaiDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDiaBanManagerBase()
		{
			// Nothing for now.
		}
		
		public PhanLoaiDiaBanEntity Insert(PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PhanLoaiDiaBanEntity, true);
			}
			return _PhanLoaiDiaBanEntity;
		}

		
		public PhanLoaiDiaBanEntity Insert(Guid Id, string TenPhanLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity = new PhanLoaiDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiDiaBanEntity.Id = Id;
				_PhanLoaiDiaBanEntity.TenPhanLoaiDiaBan = TenPhanLoaiDiaBan;
				_PhanLoaiDiaBanEntity.IdMaCha = IdMaCha;
				_PhanLoaiDiaBanEntity.MaRutGon = MaRutGon;
				_PhanLoaiDiaBanEntity.MaTp = MaTp;
				_PhanLoaiDiaBanEntity.GhiChu = GhiChu;
				_PhanLoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiDiaBanEntity.NgayTao = NgayTao;
				_PhanLoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiDiaBanEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiDiaBanEntity, true);
			}
			return _PhanLoaiDiaBanEntity;
		}

		public PhanLoaiDiaBanEntity Insert(string TenPhanLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity = new PhanLoaiDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiDiaBanEntity.TenPhanLoaiDiaBan = TenPhanLoaiDiaBan;
				_PhanLoaiDiaBanEntity.IdMaCha = IdMaCha;
				_PhanLoaiDiaBanEntity.MaRutGon = MaRutGon;
				_PhanLoaiDiaBanEntity.MaTp = MaTp;
				_PhanLoaiDiaBanEntity.GhiChu = GhiChu;
				_PhanLoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiDiaBanEntity.NgayTao = NgayTao;
				_PhanLoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiDiaBanEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiDiaBanEntity, true);
			}
			return _PhanLoaiDiaBanEntity;
		}

		public bool Update(PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == _PhanLoaiDiaBanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhanLoaiDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhanLoaiDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenPhanLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity = new PhanLoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDiaBanEntity))
				{
				
					_PhanLoaiDiaBanEntity.TenPhanLoaiDiaBan = TenPhanLoaiDiaBan;
					_PhanLoaiDiaBanEntity.IdMaCha = IdMaCha;
					_PhanLoaiDiaBanEntity.MaRutGon = MaRutGon;
					_PhanLoaiDiaBanEntity.MaTp = MaTp;
					_PhanLoaiDiaBanEntity.GhiChu = GhiChu;
					_PhanLoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_PhanLoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
					_PhanLoaiDiaBanEntity.NgayTao = NgayTao;
					_PhanLoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_PhanLoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
					_PhanLoaiDiaBanEntity.NgayHetHan = NgayHetHan;
					_PhanLoaiDiaBanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_PhanLoaiDiaBanEntity, true);
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
				PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity = new PhanLoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDiaBanEntity))
				{
					adapter.DeleteEntity(_PhanLoaiDiaBanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenPhanLoaiDiaBan(string TenPhanLoaiDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		

		
		public PhanLoaiDiaBanEntity SelectOne(Guid Id)
		{
			PhanLoaiDiaBanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiDiaBanEntity _PhanLoaiDiaBanEntity = new PhanLoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDiaBanEntity))
				{
					toReturn = _PhanLoaiDiaBanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectAllLST()
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, null, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByTenPhanLoaiDiaBanLST(string TenPhanLoaiDiaBan)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByTenPhanLoaiDiaBanLST_Paged(string TenPhanLoaiDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhanLoaiDiaBanRDT(string TenPhanLoaiDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhanLoaiDiaBanRDT_Paged(string TenPhanLoaiDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TenPhanLoaiDiaBan == TenPhanLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return EntityCollection<PhanLoaiDiaBanEntity>
		public EntityCollection<PhanLoaiDiaBanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDiaBanEntity> _PhanLoaiDiaBanCollection = new EntityCollection<PhanLoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDiaBanCollection = new EntityCollection(new PhanLoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

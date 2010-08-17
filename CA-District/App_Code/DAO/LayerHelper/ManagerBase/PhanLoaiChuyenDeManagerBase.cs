




/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiChuyenDeManagerBase
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
	public class PhanLoaiChuyenDeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiChuyenDeManagerBase()
		{
			// Nothing for now.
		}
		
		public PhanLoaiChuyenDeEntity Insert(PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PhanLoaiChuyenDeEntity, true);
			}
			return _PhanLoaiChuyenDeEntity;
		}

		
		public PhanLoaiChuyenDeEntity Insert(Guid Id, string TenPhanLoaiChuyenDe, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity = new PhanLoaiChuyenDeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiChuyenDeEntity.Id = Id;
				_PhanLoaiChuyenDeEntity.TenPhanLoaiChuyenDe = TenPhanLoaiChuyenDe;
				_PhanLoaiChuyenDeEntity.IdMaCha = IdMaCha;
				_PhanLoaiChuyenDeEntity.MaRutGon = MaRutGon;
				_PhanLoaiChuyenDeEntity.MaTp = MaTp;
				_PhanLoaiChuyenDeEntity.GhiChu = GhiChu;
				_PhanLoaiChuyenDeEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiChuyenDeEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiChuyenDeEntity.NgayTao = NgayTao;
				_PhanLoaiChuyenDeEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiChuyenDeEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiChuyenDeEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiChuyenDeEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiChuyenDeEntity, true);
			}
			return _PhanLoaiChuyenDeEntity;
		}

		public PhanLoaiChuyenDeEntity Insert(string TenPhanLoaiChuyenDe, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity = new PhanLoaiChuyenDeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiChuyenDeEntity.TenPhanLoaiChuyenDe = TenPhanLoaiChuyenDe;
				_PhanLoaiChuyenDeEntity.IdMaCha = IdMaCha;
				_PhanLoaiChuyenDeEntity.MaRutGon = MaRutGon;
				_PhanLoaiChuyenDeEntity.MaTp = MaTp;
				_PhanLoaiChuyenDeEntity.GhiChu = GhiChu;
				_PhanLoaiChuyenDeEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiChuyenDeEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiChuyenDeEntity.NgayTao = NgayTao;
				_PhanLoaiChuyenDeEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiChuyenDeEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiChuyenDeEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiChuyenDeEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiChuyenDeEntity, true);
			}
			return _PhanLoaiChuyenDeEntity;
		}

		public bool Update(PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == _PhanLoaiChuyenDeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhanLoaiChuyenDeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhanLoaiChuyenDeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenPhanLoaiChuyenDe, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity = new PhanLoaiChuyenDeEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiChuyenDeEntity))
				{
				
					_PhanLoaiChuyenDeEntity.TenPhanLoaiChuyenDe = TenPhanLoaiChuyenDe;
					_PhanLoaiChuyenDeEntity.IdMaCha = IdMaCha;
					_PhanLoaiChuyenDeEntity.MaRutGon = MaRutGon;
					_PhanLoaiChuyenDeEntity.MaTp = MaTp;
					_PhanLoaiChuyenDeEntity.GhiChu = GhiChu;
					_PhanLoaiChuyenDeEntity.LoaiDanhMuc = LoaiDanhMuc;
					_PhanLoaiChuyenDeEntity.IdNguoiTao = IdNguoiTao;
					_PhanLoaiChuyenDeEntity.NgayTao = NgayTao;
					_PhanLoaiChuyenDeEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_PhanLoaiChuyenDeEntity.NgayCapNhat = NgayCapNhat;
					_PhanLoaiChuyenDeEntity.NgayHetHan = NgayHetHan;
					_PhanLoaiChuyenDeEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_PhanLoaiChuyenDeEntity, true);
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
				PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity = new PhanLoaiChuyenDeEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiChuyenDeEntity))
				{
					adapter.DeleteEntity(_PhanLoaiChuyenDeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenPhanLoaiChuyenDe(string TenPhanLoaiChuyenDe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiChuyenDeEntity", filter);
			}
			return toReturn;
		}
		

		
		public PhanLoaiChuyenDeEntity SelectOne(Guid Id)
		{
			PhanLoaiChuyenDeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiChuyenDeEntity _PhanLoaiChuyenDeEntity = new PhanLoaiChuyenDeEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiChuyenDeEntity))
				{
					toReturn = _PhanLoaiChuyenDeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectAllLST()
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, null, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByTenPhanLoaiChuyenDeLST(string TenPhanLoaiChuyenDe)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByTenPhanLoaiChuyenDeLST_Paged(string TenPhanLoaiChuyenDe, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhanLoaiChuyenDeRDT(string TenPhanLoaiChuyenDe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenPhanLoaiChuyenDeRDT_Paged(string TenPhanLoaiChuyenDe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return EntityCollection<PhanLoaiChuyenDeEntity>
		public EntityCollection<PhanLoaiChuyenDeEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiChuyenDeEntity> _PhanLoaiChuyenDeCollection = new EntityCollection<PhanLoaiChuyenDeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiChuyenDeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiChuyenDeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiChuyenDeCollection = new EntityCollection(new PhanLoaiChuyenDeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiChuyenDeFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiChuyenDeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

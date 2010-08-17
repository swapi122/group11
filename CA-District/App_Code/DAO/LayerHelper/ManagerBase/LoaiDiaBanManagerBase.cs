




/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiDiaBanManagerBase
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
	public class LoaiDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiDiaBanManagerBase()
		{
			// Nothing for now.
		}
		
		public LoaiDiaBanEntity Insert(LoaiDiaBanEntity _LoaiDiaBanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_LoaiDiaBanEntity, true);
			}
			return _LoaiDiaBanEntity;
		}

		
		public LoaiDiaBanEntity Insert(Guid Id, string TenLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiDiaBanEntity _LoaiDiaBanEntity = new LoaiDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiDiaBanEntity.Id = Id;
				_LoaiDiaBanEntity.TenLoaiDiaBan = TenLoaiDiaBan;
				_LoaiDiaBanEntity.IdMaCha = IdMaCha;
				_LoaiDiaBanEntity.MaRutGon = MaRutGon;
				_LoaiDiaBanEntity.MaTp = MaTp;
				_LoaiDiaBanEntity.GhiChu = GhiChu;
				_LoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_LoaiDiaBanEntity.NgayTao = NgayTao;
				_LoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_LoaiDiaBanEntity.NgayHetHan = NgayHetHan;
				_LoaiDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiDiaBanEntity, true);
			}
			return _LoaiDiaBanEntity;
		}

		public LoaiDiaBanEntity Insert(string TenLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiDiaBanEntity _LoaiDiaBanEntity = new LoaiDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiDiaBanEntity.TenLoaiDiaBan = TenLoaiDiaBan;
				_LoaiDiaBanEntity.IdMaCha = IdMaCha;
				_LoaiDiaBanEntity.MaRutGon = MaRutGon;
				_LoaiDiaBanEntity.MaTp = MaTp;
				_LoaiDiaBanEntity.GhiChu = GhiChu;
				_LoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_LoaiDiaBanEntity.NgayTao = NgayTao;
				_LoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_LoaiDiaBanEntity.NgayHetHan = NgayHetHan;
				_LoaiDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiDiaBanEntity, true);
			}
			return _LoaiDiaBanEntity;
		}

		public bool Update(LoaiDiaBanEntity _LoaiDiaBanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(LoaiDiaBanFields.Id == _LoaiDiaBanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LoaiDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LoaiDiaBanEntity _LoaiDiaBanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LoaiDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenLoaiDiaBan, Guid IdMaCha, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiDiaBanEntity _LoaiDiaBanEntity = new LoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_LoaiDiaBanEntity))
				{
				
					_LoaiDiaBanEntity.TenLoaiDiaBan = TenLoaiDiaBan;
					_LoaiDiaBanEntity.IdMaCha = IdMaCha;
					_LoaiDiaBanEntity.MaRutGon = MaRutGon;
					_LoaiDiaBanEntity.MaTp = MaTp;
					_LoaiDiaBanEntity.GhiChu = GhiChu;
					_LoaiDiaBanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_LoaiDiaBanEntity.IdNguoiTao = IdNguoiTao;
					_LoaiDiaBanEntity.NgayTao = NgayTao;
					_LoaiDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_LoaiDiaBanEntity.NgayCapNhat = NgayCapNhat;
					_LoaiDiaBanEntity.NgayHetHan = NgayHetHan;
					_LoaiDiaBanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_LoaiDiaBanEntity, true);
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
				LoaiDiaBanEntity _LoaiDiaBanEntity = new LoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_LoaiDiaBanEntity))
				{
					adapter.DeleteEntity(_LoaiDiaBanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenLoaiDiaBan(string TenLoaiDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TenLoaiDiaBan == TenLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdMaCha(Guid IdMaCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiDiaBanEntity", filter);
			}
			return toReturn;
		}
		

		
		public LoaiDiaBanEntity SelectOne(Guid Id)
		{
			LoaiDiaBanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiDiaBanEntity _LoaiDiaBanEntity = new LoaiDiaBanEntity(Id);
				if (adapter.FetchEntity(_LoaiDiaBanEntity))
				{
					toReturn = _LoaiDiaBanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectAllLST()
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, null, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByTenLoaiDiaBanLST(string TenLoaiDiaBan)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TenLoaiDiaBan == TenLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByTenLoaiDiaBanLST_Paged(string TenLoaiDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TenLoaiDiaBan == TenLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiDiaBanRDT(string TenLoaiDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TenLoaiDiaBan == TenLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiDiaBanRDT_Paged(string TenLoaiDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TenLoaiDiaBan == TenLoaiDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdMaChaLST(Guid IdMaCha)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdMaChaLST_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT(Guid IdMaCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdMaChaRDT_Paged(Guid IdMaCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdMaCha == IdMaCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return EntityCollection<LoaiDiaBanEntity>
		public EntityCollection<LoaiDiaBanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiDiaBanEntity> _LoaiDiaBanCollection = new EntityCollection<LoaiDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiDiaBanCollection = new EntityCollection(new LoaiDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

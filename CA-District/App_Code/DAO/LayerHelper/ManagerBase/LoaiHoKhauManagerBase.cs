




/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiHoKhauManagerBase
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
	public class LoaiHoKhauManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiHoKhauManagerBase()
		{
			// Nothing for now.
		}
		
		public LoaiHoKhauEntity Insert(LoaiHoKhauEntity _LoaiHoKhauEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_LoaiHoKhauEntity, true);
			}
			return _LoaiHoKhauEntity;
		}

		
		public LoaiHoKhauEntity Insert(Guid Id, string TenLoaiHoKhau, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiHoKhauEntity _LoaiHoKhauEntity = new LoaiHoKhauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiHoKhauEntity.Id = Id;
				_LoaiHoKhauEntity.TenLoaiHoKhau = TenLoaiHoKhau;
				_LoaiHoKhauEntity.MaRutGon = MaRutGon;
				_LoaiHoKhauEntity.GhiChu = GhiChu;
				_LoaiHoKhauEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiHoKhauEntity.IdNguoiTao = IdNguoiTao;
				_LoaiHoKhauEntity.NgayTao = NgayTao;
				_LoaiHoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiHoKhauEntity.NgayCapNhat = NgayCapNhat;
				_LoaiHoKhauEntity.NgayHetHan = NgayHetHan;
				_LoaiHoKhauEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiHoKhauEntity, true);
			}
			return _LoaiHoKhauEntity;
		}

		public LoaiHoKhauEntity Insert(string TenLoaiHoKhau, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiHoKhauEntity _LoaiHoKhauEntity = new LoaiHoKhauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiHoKhauEntity.TenLoaiHoKhau = TenLoaiHoKhau;
				_LoaiHoKhauEntity.MaRutGon = MaRutGon;
				_LoaiHoKhauEntity.GhiChu = GhiChu;
				_LoaiHoKhauEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiHoKhauEntity.IdNguoiTao = IdNguoiTao;
				_LoaiHoKhauEntity.NgayTao = NgayTao;
				_LoaiHoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiHoKhauEntity.NgayCapNhat = NgayCapNhat;
				_LoaiHoKhauEntity.NgayHetHan = NgayHetHan;
				_LoaiHoKhauEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiHoKhauEntity, true);
			}
			return _LoaiHoKhauEntity;
		}

		public bool Update(LoaiHoKhauEntity _LoaiHoKhauEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(LoaiHoKhauFields.Id == _LoaiHoKhauEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LoaiHoKhauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LoaiHoKhauEntity _LoaiHoKhauEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LoaiHoKhauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenLoaiHoKhau, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiHoKhauEntity _LoaiHoKhauEntity = new LoaiHoKhauEntity(Id);
				if (adapter.FetchEntity(_LoaiHoKhauEntity))
				{
				
					_LoaiHoKhauEntity.TenLoaiHoKhau = TenLoaiHoKhau;
					_LoaiHoKhauEntity.MaRutGon = MaRutGon;
					_LoaiHoKhauEntity.GhiChu = GhiChu;
					_LoaiHoKhauEntity.LoaiDanhMuc = LoaiDanhMuc;
					_LoaiHoKhauEntity.IdNguoiTao = IdNguoiTao;
					_LoaiHoKhauEntity.NgayTao = NgayTao;
					_LoaiHoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_LoaiHoKhauEntity.NgayCapNhat = NgayCapNhat;
					_LoaiHoKhauEntity.NgayHetHan = NgayHetHan;
					_LoaiHoKhauEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_LoaiHoKhauEntity, true);
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
				LoaiHoKhauEntity _LoaiHoKhauEntity = new LoaiHoKhauEntity(Id);
				if (adapter.FetchEntity(_LoaiHoKhauEntity))
				{
					adapter.DeleteEntity(_LoaiHoKhauEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenLoaiHoKhau(string TenLoaiHoKhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TenLoaiHoKhau == TenLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiHoKhauEntity", filter);
			}
			return toReturn;
		}
		

		
		public LoaiHoKhauEntity SelectOne(Guid Id)
		{
			LoaiHoKhauEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiHoKhauEntity _LoaiHoKhauEntity = new LoaiHoKhauEntity(Id);
				if (adapter.FetchEntity(_LoaiHoKhauEntity))
				{
					toReturn = _LoaiHoKhauEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectAllLST()
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, null, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByTenLoaiHoKhauLST(string TenLoaiHoKhau)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TenLoaiHoKhau == TenLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByTenLoaiHoKhauLST_Paged(string TenLoaiHoKhau, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TenLoaiHoKhau == TenLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiHoKhauRDT(string TenLoaiHoKhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TenLoaiHoKhau == TenLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiHoKhauRDT_Paged(string TenLoaiHoKhau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TenLoaiHoKhau == TenLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return EntityCollection<LoaiHoKhauEntity>
		public EntityCollection<LoaiHoKhauEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiHoKhauEntity> _LoaiHoKhauCollection = new EntityCollection<LoaiHoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiHoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiHoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiHoKhauCollection = new EntityCollection(new LoaiHoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiHoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiHoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

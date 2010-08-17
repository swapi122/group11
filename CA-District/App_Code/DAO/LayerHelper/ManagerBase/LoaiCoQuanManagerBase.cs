




/*
'===============================================================================
'  LayerHelper.CAQ.BL.LoaiCoQuanManagerBase
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
	public class LoaiCoQuanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LoaiCoQuanManagerBase()
		{
			// Nothing for now.
		}
		
		public LoaiCoQuanEntity Insert(LoaiCoQuanEntity _LoaiCoQuanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_LoaiCoQuanEntity, true);
			}
			return _LoaiCoQuanEntity;
		}

		
		public LoaiCoQuanEntity Insert(Guid Id, string TenLoaiCoQuan, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiCoQuanEntity _LoaiCoQuanEntity = new LoaiCoQuanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiCoQuanEntity.Id = Id;
				_LoaiCoQuanEntity.TenLoaiCoQuan = TenLoaiCoQuan;
				_LoaiCoQuanEntity.MaRutGon = MaRutGon;
				_LoaiCoQuanEntity.GhiChu = GhiChu;
				_LoaiCoQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiCoQuanEntity.IdNguoiTao = IdNguoiTao;
				_LoaiCoQuanEntity.NgayTao = NgayTao;
				_LoaiCoQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiCoQuanEntity.NgayCapNhat = NgayCapNhat;
				_LoaiCoQuanEntity.NgayHetHan = NgayHetHan;
				_LoaiCoQuanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiCoQuanEntity, true);
			}
			return _LoaiCoQuanEntity;
		}

		public LoaiCoQuanEntity Insert(string TenLoaiCoQuan, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			LoaiCoQuanEntity _LoaiCoQuanEntity = new LoaiCoQuanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_LoaiCoQuanEntity.TenLoaiCoQuan = TenLoaiCoQuan;
				_LoaiCoQuanEntity.MaRutGon = MaRutGon;
				_LoaiCoQuanEntity.GhiChu = GhiChu;
				_LoaiCoQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
				_LoaiCoQuanEntity.IdNguoiTao = IdNguoiTao;
				_LoaiCoQuanEntity.NgayTao = NgayTao;
				_LoaiCoQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_LoaiCoQuanEntity.NgayCapNhat = NgayCapNhat;
				_LoaiCoQuanEntity.NgayHetHan = NgayHetHan;
				_LoaiCoQuanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_LoaiCoQuanEntity, true);
			}
			return _LoaiCoQuanEntity;
		}

		public bool Update(LoaiCoQuanEntity _LoaiCoQuanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(LoaiCoQuanFields.Id == _LoaiCoQuanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_LoaiCoQuanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(LoaiCoQuanEntity _LoaiCoQuanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_LoaiCoQuanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenLoaiCoQuan, string MaRutGon, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiCoQuanEntity _LoaiCoQuanEntity = new LoaiCoQuanEntity(Id);
				if (adapter.FetchEntity(_LoaiCoQuanEntity))
				{
				
					_LoaiCoQuanEntity.TenLoaiCoQuan = TenLoaiCoQuan;
					_LoaiCoQuanEntity.MaRutGon = MaRutGon;
					_LoaiCoQuanEntity.GhiChu = GhiChu;
					_LoaiCoQuanEntity.LoaiDanhMuc = LoaiDanhMuc;
					_LoaiCoQuanEntity.IdNguoiTao = IdNguoiTao;
					_LoaiCoQuanEntity.NgayTao = NgayTao;
					_LoaiCoQuanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_LoaiCoQuanEntity.NgayCapNhat = NgayCapNhat;
					_LoaiCoQuanEntity.NgayHetHan = NgayHetHan;
					_LoaiCoQuanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_LoaiCoQuanEntity, true);
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
				LoaiCoQuanEntity _LoaiCoQuanEntity = new LoaiCoQuanEntity(Id);
				if (adapter.FetchEntity(_LoaiCoQuanEntity))
				{
					adapter.DeleteEntity(_LoaiCoQuanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenLoaiCoQuan(string TenLoaiCoQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TenLoaiCoQuan == TenLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("LoaiCoQuanEntity", filter);
			}
			return toReturn;
		}
		

		
		public LoaiCoQuanEntity SelectOne(Guid Id)
		{
			LoaiCoQuanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				LoaiCoQuanEntity _LoaiCoQuanEntity = new LoaiCoQuanEntity(Id);
				if (adapter.FetchEntity(_LoaiCoQuanEntity))
				{
					toReturn = _LoaiCoQuanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectAllLST()
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, null, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByTenLoaiCoQuanLST(string TenLoaiCoQuan)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TenLoaiCoQuan == TenLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByTenLoaiCoQuanLST_Paged(string TenLoaiCoQuan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TenLoaiCoQuan == TenLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiCoQuanRDT(string TenLoaiCoQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TenLoaiCoQuan == TenLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenLoaiCoQuanRDT_Paged(string TenLoaiCoQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TenLoaiCoQuan == TenLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return EntityCollection<LoaiCoQuanEntity>
		public EntityCollection<LoaiCoQuanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<LoaiCoQuanEntity> _LoaiCoQuanCollection = new EntityCollection<LoaiCoQuanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_LoaiCoQuanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _LoaiCoQuanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _LoaiCoQuanCollection = new EntityCollection(new LoaiCoQuanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(LoaiCoQuanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_LoaiCoQuanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

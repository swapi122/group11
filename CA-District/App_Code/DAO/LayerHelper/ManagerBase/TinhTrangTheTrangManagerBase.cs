




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TinhTrangTheTrangManagerBase
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
	public class TinhTrangTheTrangManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TinhTrangTheTrangManagerBase()
		{
			// Nothing for now.
		}
		
		public TinhTrangTheTrangEntity Insert(TinhTrangTheTrangEntity _TinhTrangTheTrangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TinhTrangTheTrangEntity, true);
			}
			return _TinhTrangTheTrangEntity;
		}

		
		public TinhTrangTheTrangEntity Insert(Guid Id, string TenTinhTrangTheTrang, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangTheTrangEntity _TinhTrangTheTrangEntity = new TinhTrangTheTrangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangTheTrangEntity.Id = Id;
				_TinhTrangTheTrangEntity.TenTinhTrangTheTrang = TenTinhTrangTheTrang;
				_TinhTrangTheTrangEntity.MaRutGon = MaRutGon;
				_TinhTrangTheTrangEntity.MaTp = MaTp;
				_TinhTrangTheTrangEntity.GhiChu = GhiChu;
				_TinhTrangTheTrangEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangTheTrangEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangTheTrangEntity.NgayTao = NgayTao;
				_TinhTrangTheTrangEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangTheTrangEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangTheTrangEntity.NgayHetHan = NgayHetHan;
				_TinhTrangTheTrangEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangTheTrangEntity, true);
			}
			return _TinhTrangTheTrangEntity;
		}

		public TinhTrangTheTrangEntity Insert(string TenTinhTrangTheTrang, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			TinhTrangTheTrangEntity _TinhTrangTheTrangEntity = new TinhTrangTheTrangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TinhTrangTheTrangEntity.TenTinhTrangTheTrang = TenTinhTrangTheTrang;
				_TinhTrangTheTrangEntity.MaRutGon = MaRutGon;
				_TinhTrangTheTrangEntity.MaTp = MaTp;
				_TinhTrangTheTrangEntity.GhiChu = GhiChu;
				_TinhTrangTheTrangEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TinhTrangTheTrangEntity.IdNguoiTao = IdNguoiTao;
				_TinhTrangTheTrangEntity.NgayTao = NgayTao;
				_TinhTrangTheTrangEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TinhTrangTheTrangEntity.NgayCapNhat = NgayCapNhat;
				_TinhTrangTheTrangEntity.NgayHetHan = NgayHetHan;
				_TinhTrangTheTrangEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TinhTrangTheTrangEntity, true);
			}
			return _TinhTrangTheTrangEntity;
		}

		public bool Update(TinhTrangTheTrangEntity _TinhTrangTheTrangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TinhTrangTheTrangFields.Id == _TinhTrangTheTrangEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TinhTrangTheTrangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TinhTrangTheTrangEntity _TinhTrangTheTrangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TinhTrangTheTrangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenTinhTrangTheTrang, string MaRutGon, string MaTp, string GhiChu, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangTheTrangEntity _TinhTrangTheTrangEntity = new TinhTrangTheTrangEntity(Id);
				if (adapter.FetchEntity(_TinhTrangTheTrangEntity))
				{
				
					_TinhTrangTheTrangEntity.TenTinhTrangTheTrang = TenTinhTrangTheTrang;
					_TinhTrangTheTrangEntity.MaRutGon = MaRutGon;
					_TinhTrangTheTrangEntity.MaTp = MaTp;
					_TinhTrangTheTrangEntity.GhiChu = GhiChu;
					_TinhTrangTheTrangEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TinhTrangTheTrangEntity.IdNguoiTao = IdNguoiTao;
					_TinhTrangTheTrangEntity.NgayTao = NgayTao;
					_TinhTrangTheTrangEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TinhTrangTheTrangEntity.NgayCapNhat = NgayCapNhat;
					_TinhTrangTheTrangEntity.NgayHetHan = NgayHetHan;
					_TinhTrangTheTrangEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TinhTrangTheTrangEntity, true);
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
				TinhTrangTheTrangEntity _TinhTrangTheTrangEntity = new TinhTrangTheTrangEntity(Id);
				if (adapter.FetchEntity(_TinhTrangTheTrangEntity))
				{
					adapter.DeleteEntity(_TinhTrangTheTrangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTinhTrangTheTrang(string TenTinhTrangTheTrang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TenTinhTrangTheTrang == TenTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TinhTrangTheTrangEntity", filter);
			}
			return toReturn;
		}
		

		
		public TinhTrangTheTrangEntity SelectOne(Guid Id)
		{
			TinhTrangTheTrangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TinhTrangTheTrangEntity _TinhTrangTheTrangEntity = new TinhTrangTheTrangEntity(Id);
				if (adapter.FetchEntity(_TinhTrangTheTrangEntity))
				{
					toReturn = _TinhTrangTheTrangEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectAllLST()
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, null, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByTenTinhTrangTheTrangLST(string TenTinhTrangTheTrang)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TenTinhTrangTheTrang == TenTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByTenTinhTrangTheTrangLST_Paged(string TenTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TenTinhTrangTheTrang == TenTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangTheTrangRDT(string TenTinhTrangTheTrang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TenTinhTrangTheTrang == TenTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTinhTrangTheTrangRDT_Paged(string TenTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TenTinhTrangTheTrang == TenTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return EntityCollection<TinhTrangTheTrangEntity>
		public EntityCollection<TinhTrangTheTrangEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TinhTrangTheTrangEntity> _TinhTrangTheTrangCollection = new EntityCollection<TinhTrangTheTrangEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TinhTrangTheTrangCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TinhTrangTheTrangCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TinhTrangTheTrangCollection = new EntityCollection(new TinhTrangTheTrangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TinhTrangTheTrangFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TinhTrangTheTrangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

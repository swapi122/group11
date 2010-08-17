




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TapTinDinhKemManagerBase
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
	public class TapTinDinhKemManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TapTinDinhKemManagerBase()
		{
			// Nothing for now.
		}
		
		public TapTinDinhKemEntity Insert(TapTinDinhKemEntity _TapTinDinhKemEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TapTinDinhKemEntity, true);
			}
			return _TapTinDinhKemEntity;
		}

		
		public TapTinDinhKemEntity Insert(Guid Id, Guid IdVuViec, string TenTapTinDinhKem, Guid IdLoaiTapTin, string DuongDan, string MoTa, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TapTinDinhKemEntity _TapTinDinhKemEntity = new TapTinDinhKemEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TapTinDinhKemEntity.Id = Id;
				_TapTinDinhKemEntity.IdVuViec = IdVuViec;
				_TapTinDinhKemEntity.TenTapTinDinhKem = TenTapTinDinhKem;
				_TapTinDinhKemEntity.IdLoaiTapTin = IdLoaiTapTin;
				_TapTinDinhKemEntity.DuongDan = DuongDan;
				_TapTinDinhKemEntity.MoTa = MoTa;
				_TapTinDinhKemEntity.IdNguoiTao = IdNguoiTao;
				_TapTinDinhKemEntity.NgayTao = NgayTao;
				_TapTinDinhKemEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TapTinDinhKemEntity.NgayCapNhat = NgayCapNhat;
				_TapTinDinhKemEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TapTinDinhKemEntity, true);
			}
			return _TapTinDinhKemEntity;
		}

		public TapTinDinhKemEntity Insert(Guid IdVuViec, string TenTapTinDinhKem, Guid IdLoaiTapTin, string DuongDan, string MoTa, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TapTinDinhKemEntity _TapTinDinhKemEntity = new TapTinDinhKemEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TapTinDinhKemEntity.IdVuViec = IdVuViec;
				_TapTinDinhKemEntity.TenTapTinDinhKem = TenTapTinDinhKem;
				_TapTinDinhKemEntity.IdLoaiTapTin = IdLoaiTapTin;
				_TapTinDinhKemEntity.DuongDan = DuongDan;
				_TapTinDinhKemEntity.MoTa = MoTa;
				_TapTinDinhKemEntity.IdNguoiTao = IdNguoiTao;
				_TapTinDinhKemEntity.NgayTao = NgayTao;
				_TapTinDinhKemEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TapTinDinhKemEntity.NgayCapNhat = NgayCapNhat;
				_TapTinDinhKemEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TapTinDinhKemEntity, true);
			}
			return _TapTinDinhKemEntity;
		}

		public bool Update(TapTinDinhKemEntity _TapTinDinhKemEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TapTinDinhKemFields.Id == _TapTinDinhKemEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TapTinDinhKemEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TapTinDinhKemEntity _TapTinDinhKemEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TapTinDinhKemEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, string TenTapTinDinhKem, Guid IdLoaiTapTin, string DuongDan, string MoTa, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TapTinDinhKemEntity _TapTinDinhKemEntity = new TapTinDinhKemEntity(Id);
				if (adapter.FetchEntity(_TapTinDinhKemEntity))
				{
				
					_TapTinDinhKemEntity.IdVuViec = IdVuViec;
					_TapTinDinhKemEntity.TenTapTinDinhKem = TenTapTinDinhKem;
					_TapTinDinhKemEntity.IdLoaiTapTin = IdLoaiTapTin;
					_TapTinDinhKemEntity.DuongDan = DuongDan;
					_TapTinDinhKemEntity.MoTa = MoTa;
					_TapTinDinhKemEntity.IdNguoiTao = IdNguoiTao;
					_TapTinDinhKemEntity.NgayTao = NgayTao;
					_TapTinDinhKemEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TapTinDinhKemEntity.NgayCapNhat = NgayCapNhat;
					_TapTinDinhKemEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TapTinDinhKemEntity, true);
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
				TapTinDinhKemEntity _TapTinDinhKemEntity = new TapTinDinhKemEntity(Id);
				if (adapter.FetchEntity(_TapTinDinhKemEntity))
				{
					adapter.DeleteEntity(_TapTinDinhKemEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenTapTinDinhKem(string TenTapTinDinhKem)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TenTapTinDinhKem == TenTapTinDinhKem);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiTapTin(Guid IdLoaiTapTin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdLoaiTapTin == IdLoaiTapTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDuongDan(string DuongDan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.DuongDan == DuongDan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMoTa(string MoTa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.MoTa == MoTa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TapTinDinhKemEntity", filter);
			}
			return toReturn;
		}
		

		
		public TapTinDinhKemEntity SelectOne(Guid Id)
		{
			TapTinDinhKemEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TapTinDinhKemEntity _TapTinDinhKemEntity = new TapTinDinhKemEntity(Id);
				if (adapter.FetchEntity(_TapTinDinhKemEntity))
				{
					toReturn = _TapTinDinhKemEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectAllLST()
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, null, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByTenTapTinDinhKemLST(string TenTapTinDinhKem)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TenTapTinDinhKem == TenTapTinDinhKem);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByTenTapTinDinhKemLST_Paged(string TenTapTinDinhKem, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TenTapTinDinhKem == TenTapTinDinhKem);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenTapTinDinhKemRDT(string TenTapTinDinhKem)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TenTapTinDinhKem == TenTapTinDinhKem);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenTapTinDinhKemRDT_Paged(string TenTapTinDinhKem, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TenTapTinDinhKem == TenTapTinDinhKem);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdLoaiTapTinLST(Guid IdLoaiTapTin)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdLoaiTapTin == IdLoaiTapTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdLoaiTapTinLST_Paged(Guid IdLoaiTapTin, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdLoaiTapTin == IdLoaiTapTin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTapTinRDT(Guid IdLoaiTapTin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdLoaiTapTin == IdLoaiTapTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTapTinRDT_Paged(Guid IdLoaiTapTin, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdLoaiTapTin == IdLoaiTapTin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByDuongDanLST(string DuongDan)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.DuongDan == DuongDan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByDuongDanLST_Paged(string DuongDan, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.DuongDan == DuongDan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDuongDanRDT(string DuongDan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.DuongDan == DuongDan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDuongDanRDT_Paged(string DuongDan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.DuongDan == DuongDan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByMoTaLST(string MoTa)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.MoTa == MoTa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByMoTaLST_Paged(string MoTa, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.MoTa == MoTa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMoTaRDT(string MoTa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.MoTa == MoTa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMoTaRDT_Paged(string MoTa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.MoTa == MoTa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return EntityCollection<TapTinDinhKemEntity>
		public EntityCollection<TapTinDinhKemEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TapTinDinhKemEntity> _TapTinDinhKemCollection = new EntityCollection<TapTinDinhKemEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TapTinDinhKemCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TapTinDinhKemCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TapTinDinhKemCollection = new EntityCollection(new TapTinDinhKemEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TapTinDinhKemFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TapTinDinhKemCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

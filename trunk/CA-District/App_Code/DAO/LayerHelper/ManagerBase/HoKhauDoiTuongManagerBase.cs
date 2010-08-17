




/*
'===============================================================================
'  LayerHelper.CAQ.BL.HoKhauDoiTuongManagerBase
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
	public class HoKhauDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HoKhauDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public HoKhauDoiTuongEntity Insert(HoKhauDoiTuongEntity _HoKhauDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HoKhauDoiTuongEntity, true);
			}
			return _HoKhauDoiTuongEntity;
		}

		
		public HoKhauDoiTuongEntity Insert(Guid Id, Guid IdHoKhau, Guid IdDoiTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HoKhauDoiTuongEntity _HoKhauDoiTuongEntity = new HoKhauDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HoKhauDoiTuongEntity.Id = Id;
				_HoKhauDoiTuongEntity.IdHoKhau = IdHoKhau;
				_HoKhauDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_HoKhauDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_HoKhauDoiTuongEntity.NgayTao = NgayTao;
				_HoKhauDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HoKhauDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_HoKhauDoiTuongEntity.NgayHetHan = NgayHetHan;
				_HoKhauDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HoKhauDoiTuongEntity, true);
			}
			return _HoKhauDoiTuongEntity;
		}

		public HoKhauDoiTuongEntity Insert(Guid IdHoKhau, Guid IdDoiTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HoKhauDoiTuongEntity _HoKhauDoiTuongEntity = new HoKhauDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HoKhauDoiTuongEntity.IdHoKhau = IdHoKhau;
				_HoKhauDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_HoKhauDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_HoKhauDoiTuongEntity.NgayTao = NgayTao;
				_HoKhauDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HoKhauDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_HoKhauDoiTuongEntity.NgayHetHan = NgayHetHan;
				_HoKhauDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HoKhauDoiTuongEntity, true);
			}
			return _HoKhauDoiTuongEntity;
		}

		public bool Update(HoKhauDoiTuongEntity _HoKhauDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HoKhauDoiTuongFields.Id == _HoKhauDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HoKhauDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HoKhauDoiTuongEntity _HoKhauDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HoKhauDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdHoKhau, Guid IdDoiTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HoKhauDoiTuongEntity _HoKhauDoiTuongEntity = new HoKhauDoiTuongEntity(Id);
				if (adapter.FetchEntity(_HoKhauDoiTuongEntity))
				{
				
					_HoKhauDoiTuongEntity.IdHoKhau = IdHoKhau;
					_HoKhauDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_HoKhauDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_HoKhauDoiTuongEntity.NgayTao = NgayTao;
					_HoKhauDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_HoKhauDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_HoKhauDoiTuongEntity.NgayHetHan = NgayHetHan;
					_HoKhauDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_HoKhauDoiTuongEntity, true);
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
				HoKhauDoiTuongEntity _HoKhauDoiTuongEntity = new HoKhauDoiTuongEntity(Id);
				if (adapter.FetchEntity(_HoKhauDoiTuongEntity))
				{
					adapter.DeleteEntity(_HoKhauDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHoKhau(Guid IdHoKhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdHoKhau == IdHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public HoKhauDoiTuongEntity SelectOne(Guid Id)
		{
			HoKhauDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HoKhauDoiTuongEntity _HoKhauDoiTuongEntity = new HoKhauDoiTuongEntity(Id);
				if (adapter.FetchEntity(_HoKhauDoiTuongEntity))
				{
					toReturn = _HoKhauDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, null, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdHoKhauLST(Guid IdHoKhau)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdHoKhau == IdHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdHoKhauLST_Paged(Guid IdHoKhau, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdHoKhau == IdHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHoKhauRDT(Guid IdHoKhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdHoKhau == IdHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHoKhauRDT_Paged(Guid IdHoKhau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdHoKhau == IdHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return EntityCollection<HoKhauDoiTuongEntity>
		public EntityCollection<HoKhauDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauDoiTuongEntity> _HoKhauDoiTuongCollection = new EntityCollection<HoKhauDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauDoiTuongCollection = new EntityCollection(new HoKhauDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

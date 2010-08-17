




/*
'===============================================================================
'  LayerHelper.CAQ.BL.ChucNangNhomManagerBase
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
	public class ChucNangNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ChucNangNhomManagerBase()
		{
			// Nothing for now.
		}
		
		public ChucNangNhomEntity Insert(ChucNangNhomEntity _ChucNangNhomEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ChucNangNhomEntity, true);
			}
			return _ChucNangNhomEntity;
		}

		
		public ChucNangNhomEntity Insert(Guid Id, Guid IdChucNang, Guid IdNhom, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			ChucNangNhomEntity _ChucNangNhomEntity = new ChucNangNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ChucNangNhomEntity.Id = Id;
				_ChucNangNhomEntity.IdChucNang = IdChucNang;
				_ChucNangNhomEntity.IdNhom = IdNhom;
				_ChucNangNhomEntity.IdNguoiTao = IdNguoiTao;
				_ChucNangNhomEntity.NgayTao = NgayTao;
				_ChucNangNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ChucNangNhomEntity.NgayCapNhat = NgayCapNhat;
				_ChucNangNhomEntity.NgayHetHan = NgayHetHan;
				_ChucNangNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ChucNangNhomEntity, true);
			}
			return _ChucNangNhomEntity;
		}

		public ChucNangNhomEntity Insert(Guid IdChucNang, Guid IdNhom, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			ChucNangNhomEntity _ChucNangNhomEntity = new ChucNangNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ChucNangNhomEntity.IdChucNang = IdChucNang;
				_ChucNangNhomEntity.IdNhom = IdNhom;
				_ChucNangNhomEntity.IdNguoiTao = IdNguoiTao;
				_ChucNangNhomEntity.NgayTao = NgayTao;
				_ChucNangNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ChucNangNhomEntity.NgayCapNhat = NgayCapNhat;
				_ChucNangNhomEntity.NgayHetHan = NgayHetHan;
				_ChucNangNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ChucNangNhomEntity, true);
			}
			return _ChucNangNhomEntity;
		}

		public bool Update(ChucNangNhomEntity _ChucNangNhomEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ChucNangNhomFields.Id == _ChucNangNhomEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ChucNangNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ChucNangNhomEntity _ChucNangNhomEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ChucNangNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdChucNang, Guid IdNhom, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ChucNangNhomEntity _ChucNangNhomEntity = new ChucNangNhomEntity(Id);
				if (adapter.FetchEntity(_ChucNangNhomEntity))
				{
				
					_ChucNangNhomEntity.IdChucNang = IdChucNang;
					_ChucNangNhomEntity.IdNhom = IdNhom;
					_ChucNangNhomEntity.IdNguoiTao = IdNguoiTao;
					_ChucNangNhomEntity.NgayTao = NgayTao;
					_ChucNangNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_ChucNangNhomEntity.NgayCapNhat = NgayCapNhat;
					_ChucNangNhomEntity.NgayHetHan = NgayHetHan;
					_ChucNangNhomEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_ChucNangNhomEntity, true);
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
				ChucNangNhomEntity _ChucNangNhomEntity = new ChucNangNhomEntity(Id);
				if (adapter.FetchEntity(_ChucNangNhomEntity))
				{
					adapter.DeleteEntity(_ChucNangNhomEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdChucNang(Guid IdChucNang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdChucNang == IdChucNang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNhom(Guid IdNhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ChucNangNhomEntity", filter);
			}
			return toReturn;
		}
		

		
		public ChucNangNhomEntity SelectOne(Guid Id)
		{
			ChucNangNhomEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ChucNangNhomEntity _ChucNangNhomEntity = new ChucNangNhomEntity(Id);
				if (adapter.FetchEntity(_ChucNangNhomEntity))
				{
					toReturn = _ChucNangNhomEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectAllLST()
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, null, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdChucNangLST(Guid IdChucNang)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdChucNang == IdChucNang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdChucNangLST_Paged(Guid IdChucNang, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdChucNang == IdChucNang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucNangRDT(Guid IdChucNang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdChucNang == IdChucNang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucNangRDT_Paged(Guid IdChucNang, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdChucNang == IdChucNang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNhomLST(Guid IdNhom)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNhomLST_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT(Guid IdNhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return EntityCollection<ChucNangNhomEntity>
		public EntityCollection<ChucNangNhomEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<ChucNangNhomEntity> _ChucNangNhomCollection = new EntityCollection<ChucNangNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ChucNangNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ChucNangNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ChucNangNhomCollection = new EntityCollection(new ChucNangNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ChucNangNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ChucNangNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

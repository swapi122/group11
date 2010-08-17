




/*
'===============================================================================
'  LayerHelper.CAQ.BL.ColumnsCollectionManagerBase
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
	public class ColumnsCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ColumnsCollectionManagerBase()
		{
			// Nothing for now.
		}
		
		public ColumnsCollectionEntity Insert(ColumnsCollectionEntity _ColumnsCollectionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ColumnsCollectionEntity, true);
			}
			return _ColumnsCollectionEntity;
		}

		
		public ColumnsCollectionEntity Insert(Guid Id, string TableName, string ColumnName, string Title, string SqlDataType, string KeyType, int OrderIndex, bool IsShow, bool IsNullable, string Control, int MaxLength, string Width, Guid ColumnId)
		{
			ColumnsCollectionEntity _ColumnsCollectionEntity = new ColumnsCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ColumnsCollectionEntity.Id = Id;
				_ColumnsCollectionEntity.TableName = TableName;
				_ColumnsCollectionEntity.ColumnName = ColumnName;
				_ColumnsCollectionEntity.Title = Title;
				_ColumnsCollectionEntity.SqlDataType = SqlDataType;
				_ColumnsCollectionEntity.KeyType = KeyType;
				_ColumnsCollectionEntity.OrderIndex = OrderIndex;
				_ColumnsCollectionEntity.IsShow = IsShow;
				_ColumnsCollectionEntity.IsNullable = IsNullable;
				_ColumnsCollectionEntity.Control = Control;
				_ColumnsCollectionEntity.MaxLength = MaxLength;
				_ColumnsCollectionEntity.Width = Width;
				_ColumnsCollectionEntity.ColumnId = ColumnId;
				adapter.SaveEntity(_ColumnsCollectionEntity, true);
			}
			return _ColumnsCollectionEntity;
		}

		public ColumnsCollectionEntity Insert(string TableName, string ColumnName, string Title, string SqlDataType, string KeyType, int OrderIndex, bool IsShow, bool IsNullable, string Control, int MaxLength, string Width, Guid ColumnId)
		{
			ColumnsCollectionEntity _ColumnsCollectionEntity = new ColumnsCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ColumnsCollectionEntity.TableName = TableName;
				_ColumnsCollectionEntity.ColumnName = ColumnName;
				_ColumnsCollectionEntity.Title = Title;
				_ColumnsCollectionEntity.SqlDataType = SqlDataType;
				_ColumnsCollectionEntity.KeyType = KeyType;
				_ColumnsCollectionEntity.OrderIndex = OrderIndex;
				_ColumnsCollectionEntity.IsShow = IsShow;
				_ColumnsCollectionEntity.IsNullable = IsNullable;
				_ColumnsCollectionEntity.Control = Control;
				_ColumnsCollectionEntity.MaxLength = MaxLength;
				_ColumnsCollectionEntity.Width = Width;
				_ColumnsCollectionEntity.ColumnId = ColumnId;
				adapter.SaveEntity(_ColumnsCollectionEntity, true);
			}
			return _ColumnsCollectionEntity;
		}

		public bool Update(ColumnsCollectionEntity _ColumnsCollectionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ColumnsCollectionFields.Id == _ColumnsCollectionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ColumnsCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ColumnsCollectionEntity _ColumnsCollectionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ColumnsCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TableName, string ColumnName, string Title, string SqlDataType, string KeyType, int OrderIndex, bool IsShow, bool IsNullable, string Control, int MaxLength, string Width, Guid ColumnId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ColumnsCollectionEntity _ColumnsCollectionEntity = new ColumnsCollectionEntity(Id);
				if (adapter.FetchEntity(_ColumnsCollectionEntity))
				{
				
					_ColumnsCollectionEntity.TableName = TableName;
					_ColumnsCollectionEntity.ColumnName = ColumnName;
					_ColumnsCollectionEntity.Title = Title;
					_ColumnsCollectionEntity.SqlDataType = SqlDataType;
					_ColumnsCollectionEntity.KeyType = KeyType;
					_ColumnsCollectionEntity.OrderIndex = OrderIndex;
					_ColumnsCollectionEntity.IsShow = IsShow;
					_ColumnsCollectionEntity.IsNullable = IsNullable;
					_ColumnsCollectionEntity.Control = Control;
					_ColumnsCollectionEntity.MaxLength = MaxLength;
					_ColumnsCollectionEntity.Width = Width;
					_ColumnsCollectionEntity.ColumnId = ColumnId;
					adapter.SaveEntity(_ColumnsCollectionEntity, true);
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
				ColumnsCollectionEntity _ColumnsCollectionEntity = new ColumnsCollectionEntity(Id);
				if (adapter.FetchEntity(_ColumnsCollectionEntity))
				{
					adapter.DeleteEntity(_ColumnsCollectionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTableName(string TableName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByColumnName(string ColumnName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnName == ColumnName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTitle(string Title)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Title == Title);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySqlDataType(string SqlDataType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.SqlDataType == SqlDataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByKeyType(string KeyType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.KeyType == KeyType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderIndex(int OrderIndex)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsShow(bool IsShow)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsShow == IsShow);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsNullable(bool IsNullable)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsNullable == IsNullable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByControl(string Control)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Control == Control);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaxLength(int MaxLength)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.MaxLength == MaxLength);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByWidth(string Width)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByColumnId(Guid ColumnId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnId == ColumnId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ColumnsCollectionEntity", filter);
			}
			return toReturn;
		}
		

		
		public ColumnsCollectionEntity SelectOne(Guid Id)
		{
			ColumnsCollectionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ColumnsCollectionEntity _ColumnsCollectionEntity = new ColumnsCollectionEntity(Id);
				if (adapter.FetchEntity(_ColumnsCollectionEntity))
				{
					toReturn = _ColumnsCollectionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectAllLST()
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, null, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByTableNameLST(string TableName)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByTableNameLST_Paged(string TableName, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTableNameRDT(string TableName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTableNameRDT_Paged(string TableName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.TableName == TableName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByColumnNameLST(string ColumnName)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnName == ColumnName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByColumnNameLST_Paged(string ColumnName, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnName == ColumnName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByColumnNameRDT(string ColumnName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnName == ColumnName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByColumnNameRDT_Paged(string ColumnName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnName == ColumnName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByTitleLST(string Title)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Title == Title);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByTitleLST_Paged(string Title, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Title == Title);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTitleRDT(string Title)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Title == Title);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTitleRDT_Paged(string Title, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Title == Title);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectBySqlDataTypeLST(string SqlDataType)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.SqlDataType == SqlDataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectBySqlDataTypeLST_Paged(string SqlDataType, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.SqlDataType == SqlDataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySqlDataTypeRDT(string SqlDataType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.SqlDataType == SqlDataType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySqlDataTypeRDT_Paged(string SqlDataType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.SqlDataType == SqlDataType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByKeyTypeLST(string KeyType)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.KeyType == KeyType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByKeyTypeLST_Paged(string KeyType, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.KeyType == KeyType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByKeyTypeRDT(string KeyType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.KeyType == KeyType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByKeyTypeRDT_Paged(string KeyType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.KeyType == KeyType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByOrderIndexLST(int OrderIndex)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByOrderIndexLST_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT(int OrderIndex)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderIndexRDT_Paged(int OrderIndex, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.OrderIndex == OrderIndex);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIsShowLST(bool IsShow)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsShow == IsShow);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIsShowLST_Paged(bool IsShow, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsShow == IsShow);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsShowRDT(bool IsShow)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsShow == IsShow);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsShowRDT_Paged(bool IsShow, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsShow == IsShow);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIsNullableLST(bool IsNullable)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsNullable == IsNullable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByIsNullableLST_Paged(bool IsNullable, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsNullable == IsNullable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsNullableRDT(bool IsNullable)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsNullable == IsNullable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsNullableRDT_Paged(bool IsNullable, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.IsNullable == IsNullable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByControlLST(string Control)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Control == Control);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByControlLST_Paged(string Control, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Control == Control);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByControlRDT(string Control)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Control == Control);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByControlRDT_Paged(string Control, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Control == Control);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByMaxLengthLST(int MaxLength)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.MaxLength == MaxLength);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByMaxLengthLST_Paged(int MaxLength, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.MaxLength == MaxLength);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaxLengthRDT(int MaxLength)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.MaxLength == MaxLength);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaxLengthRDT_Paged(int MaxLength, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.MaxLength == MaxLength);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByWidthLST(string Width)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByWidthLST_Paged(string Width, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT(string Width)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByWidthRDT_Paged(string Width, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.Width == Width);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByColumnIdLST(Guid ColumnId)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnId == ColumnId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return EntityCollection<ColumnsCollectionEntity>
		public EntityCollection<ColumnsCollectionEntity> SelectByColumnIdLST_Paged(Guid ColumnId, int PageNumber, int PageSize)
		{
			EntityCollection<ColumnsCollectionEntity> _ColumnsCollectionCollection = new EntityCollection<ColumnsCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnId == ColumnId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ColumnsCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ColumnsCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByColumnIdRDT(Guid ColumnId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnId == ColumnId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByColumnIdRDT_Paged(Guid ColumnId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ColumnsCollectionCollection = new EntityCollection(new ColumnsCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ColumnsCollectionFields.ColumnId == ColumnId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ColumnsCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.NguoiDungVaNhomManagerBase
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
	public class NguoiDungVaNhomManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NguoiDungVaNhomManagerBase()
		{
			// Nothing for now.
		}
		
		public NguoiDungVaNhomEntity Insert(NguoiDungVaNhomEntity _NguoiDungVaNhomEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NguoiDungVaNhomEntity, true);
			}
			return _NguoiDungVaNhomEntity;
		}

		
		public NguoiDungVaNhomEntity Insert(Guid IdNguoiDungVaNhom, Guid IdNguoiDung, Guid IdNhom, string MaTp, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NguoiDungVaNhomEntity _NguoiDungVaNhomEntity = new NguoiDungVaNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NguoiDungVaNhomEntity.IdNguoiDungVaNhom = IdNguoiDungVaNhom;
				_NguoiDungVaNhomEntity.IdNguoiDung = IdNguoiDung;
				_NguoiDungVaNhomEntity.IdNhom = IdNhom;
				_NguoiDungVaNhomEntity.MaTp = MaTp;
				_NguoiDungVaNhomEntity.IdNguoiTao = IdNguoiTao;
				_NguoiDungVaNhomEntity.NgayTao = NgayTao;
				_NguoiDungVaNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NguoiDungVaNhomEntity.NgayCapNhat = NgayCapNhat;
				_NguoiDungVaNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NguoiDungVaNhomEntity, true);
			}
			return _NguoiDungVaNhomEntity;
		}

		public NguoiDungVaNhomEntity Insert(Guid IdNguoiDung, Guid IdNhom, string MaTp, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NguoiDungVaNhomEntity _NguoiDungVaNhomEntity = new NguoiDungVaNhomEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NguoiDungVaNhomEntity.IdNguoiDung = IdNguoiDung;
				_NguoiDungVaNhomEntity.IdNhom = IdNhom;
				_NguoiDungVaNhomEntity.MaTp = MaTp;
				_NguoiDungVaNhomEntity.IdNguoiTao = IdNguoiTao;
				_NguoiDungVaNhomEntity.NgayTao = NgayTao;
				_NguoiDungVaNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NguoiDungVaNhomEntity.NgayCapNhat = NgayCapNhat;
				_NguoiDungVaNhomEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NguoiDungVaNhomEntity, true);
			}
			return _NguoiDungVaNhomEntity;
		}

		public bool Update(NguoiDungVaNhomEntity _NguoiDungVaNhomEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == _NguoiDungVaNhomEntity.IdNguoiDungVaNhom);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NguoiDungVaNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NguoiDungVaNhomEntity _NguoiDungVaNhomEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NguoiDungVaNhomEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid IdNguoiDungVaNhom, Guid IdNguoiDung, Guid IdNhom, string MaTp, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NguoiDungVaNhomEntity _NguoiDungVaNhomEntity = new NguoiDungVaNhomEntity(IdNguoiDungVaNhom);
				if (adapter.FetchEntity(_NguoiDungVaNhomEntity))
				{
				
					_NguoiDungVaNhomEntity.IdNguoiDung = IdNguoiDung;
					_NguoiDungVaNhomEntity.IdNhom = IdNhom;
					_NguoiDungVaNhomEntity.MaTp = MaTp;
					_NguoiDungVaNhomEntity.IdNguoiTao = IdNguoiTao;
					_NguoiDungVaNhomEntity.NgayTao = NgayTao;
					_NguoiDungVaNhomEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NguoiDungVaNhomEntity.NgayCapNhat = NgayCapNhat;
					_NguoiDungVaNhomEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NguoiDungVaNhomEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid IdNguoiDungVaNhom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NguoiDungVaNhomEntity _NguoiDungVaNhomEntity = new NguoiDungVaNhomEntity(IdNguoiDungVaNhom);
				if (adapter.FetchEntity(_NguoiDungVaNhomEntity))
				{
					adapter.DeleteEntity(_NguoiDungVaNhomEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", null);
			}
		}
		
		
		public int DeleteByIdNguoiDungVaNhom(Guid IdNguoiDungVaNhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == IdNguoiDungVaNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiDung(Guid IdNguoiDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDung == IdNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNhom(Guid IdNhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NguoiDungVaNhomEntity", filter);
			}
			return toReturn;
		}
		

		
		public NguoiDungVaNhomEntity SelectOne(Guid IdNguoiDungVaNhom)
		{
			NguoiDungVaNhomEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NguoiDungVaNhomEntity _NguoiDungVaNhomEntity = new NguoiDungVaNhomEntity(IdNguoiDungVaNhom);
				if (adapter.FetchEntity(_NguoiDungVaNhomEntity))
				{
					toReturn = _NguoiDungVaNhomEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectAllLST()
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, null, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiDungVaNhomLST(Guid IdNguoiDungVaNhom)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == IdNguoiDungVaNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiDungVaNhomLST_Paged(Guid IdNguoiDungVaNhom, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == IdNguoiDungVaNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiDungVaNhomRDT(Guid IdNguoiDungVaNhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == IdNguoiDungVaNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiDungVaNhomRDT_Paged(Guid IdNguoiDungVaNhom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDungVaNhom == IdNguoiDungVaNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiDungLST(Guid IdNguoiDung)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDung == IdNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiDungLST_Paged(Guid IdNguoiDung, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDung == IdNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiDungRDT(Guid IdNguoiDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDung == IdNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiDungRDT_Paged(Guid IdNguoiDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiDung == IdNguoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNhomLST(Guid IdNhom)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNhomLST_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT(Guid IdNhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNhomRDT_Paged(Guid IdNhom, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNhom == IdNhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return EntityCollection<NguoiDungVaNhomEntity>
		public EntityCollection<NguoiDungVaNhomEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NguoiDungVaNhomEntity> _NguoiDungVaNhomCollection = new EntityCollection<NguoiDungVaNhomEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NguoiDungVaNhomCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NguoiDungVaNhomCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NguoiDungVaNhomCollection = new EntityCollection(new NguoiDungVaNhomEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NguoiDungVaNhomFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NguoiDungVaNhomCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.NanNhanVuViecManagerBase
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
	public class NanNhanVuViecManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NanNhanVuViecManagerBase()
		{
			// Nothing for now.
		}
		
		public NanNhanVuViecEntity Insert(NanNhanVuViecEntity _NanNhanVuViecEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NanNhanVuViecEntity, true);
			}
			return _NanNhanVuViecEntity;
		}

		
		public NanNhanVuViecEntity Insert(Guid Id, Guid IdVuViec, Guid IdNanNhan, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NanNhanVuViecEntity _NanNhanVuViecEntity = new NanNhanVuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NanNhanVuViecEntity.Id = Id;
				_NanNhanVuViecEntity.IdVuViec = IdVuViec;
				_NanNhanVuViecEntity.IdNanNhan = IdNanNhan;
				_NanNhanVuViecEntity.MaRutGon = MaRutGon;
				_NanNhanVuViecEntity.MaTp = MaTp;
				_NanNhanVuViecEntity.GhiChu = GhiChu;
				_NanNhanVuViecEntity.IdNguoiTao = IdNguoiTao;
				_NanNhanVuViecEntity.NgayTao = NgayTao;
				_NanNhanVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NanNhanVuViecEntity.NgayCapNhat = NgayCapNhat;
				_NanNhanVuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NanNhanVuViecEntity, true);
			}
			return _NanNhanVuViecEntity;
		}

		public NanNhanVuViecEntity Insert(Guid IdVuViec, Guid IdNanNhan, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			NanNhanVuViecEntity _NanNhanVuViecEntity = new NanNhanVuViecEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NanNhanVuViecEntity.IdVuViec = IdVuViec;
				_NanNhanVuViecEntity.IdNanNhan = IdNanNhan;
				_NanNhanVuViecEntity.MaRutGon = MaRutGon;
				_NanNhanVuViecEntity.MaTp = MaTp;
				_NanNhanVuViecEntity.GhiChu = GhiChu;
				_NanNhanVuViecEntity.IdNguoiTao = IdNguoiTao;
				_NanNhanVuViecEntity.NgayTao = NgayTao;
				_NanNhanVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NanNhanVuViecEntity.NgayCapNhat = NgayCapNhat;
				_NanNhanVuViecEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NanNhanVuViecEntity, true);
			}
			return _NanNhanVuViecEntity;
		}

		public bool Update(NanNhanVuViecEntity _NanNhanVuViecEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NanNhanVuViecFields.Id == _NanNhanVuViecEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NanNhanVuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NanNhanVuViecEntity _NanNhanVuViecEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NanNhanVuViecEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, Guid IdNanNhan, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NanNhanVuViecEntity _NanNhanVuViecEntity = new NanNhanVuViecEntity(Id);
				if (adapter.FetchEntity(_NanNhanVuViecEntity))
				{
				
					_NanNhanVuViecEntity.IdVuViec = IdVuViec;
					_NanNhanVuViecEntity.IdNanNhan = IdNanNhan;
					_NanNhanVuViecEntity.MaRutGon = MaRutGon;
					_NanNhanVuViecEntity.MaTp = MaTp;
					_NanNhanVuViecEntity.GhiChu = GhiChu;
					_NanNhanVuViecEntity.IdNguoiTao = IdNguoiTao;
					_NanNhanVuViecEntity.NgayTao = NgayTao;
					_NanNhanVuViecEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NanNhanVuViecEntity.NgayCapNhat = NgayCapNhat;
					_NanNhanVuViecEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NanNhanVuViecEntity, true);
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
				NanNhanVuViecEntity _NanNhanVuViecEntity = new NanNhanVuViecEntity(Id);
				if (adapter.FetchEntity(_NanNhanVuViecEntity))
				{
					adapter.DeleteEntity(_NanNhanVuViecEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNanNhan(Guid IdNanNhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNanNhan == IdNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NanNhanVuViecEntity", filter);
			}
			return toReturn;
		}
		

		
		public NanNhanVuViecEntity SelectOne(Guid Id)
		{
			NanNhanVuViecEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NanNhanVuViecEntity _NanNhanVuViecEntity = new NanNhanVuViecEntity(Id);
				if (adapter.FetchEntity(_NanNhanVuViecEntity))
				{
					toReturn = _NanNhanVuViecEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectAllLST()
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, null, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNanNhanLST(Guid IdNanNhan)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNanNhan == IdNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNanNhanLST_Paged(Guid IdNanNhan, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNanNhan == IdNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNanNhanRDT(Guid IdNanNhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNanNhan == IdNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNanNhanRDT_Paged(Guid IdNanNhan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNanNhan == IdNanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return EntityCollection<NanNhanVuViecEntity>
		public EntityCollection<NanNhanVuViecEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NanNhanVuViecEntity> _NanNhanVuViecCollection = new EntityCollection<NanNhanVuViecEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NanNhanVuViecCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NanNhanVuViecCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NanNhanVuViecCollection = new EntityCollection(new NanNhanVuViecEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NanNhanVuViecFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NanNhanVuViecCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

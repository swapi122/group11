




/*
'===============================================================================
'  LayerHelper.CAQ.BL.DoiTuongToChucManagerBase
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
	public class DoiTuongToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DoiTuongToChucManagerBase()
		{
			// Nothing for now.
		}
		
		public DoiTuongToChucEntity Insert(DoiTuongToChucEntity _DoiTuongToChucEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DoiTuongToChucEntity, true);
			}
			return _DoiTuongToChucEntity;
		}

		
		public DoiTuongToChucEntity Insert(Guid Id, Guid IdDoiTuong, Guid IdToChuc, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DoiTuongToChucEntity _DoiTuongToChucEntity = new DoiTuongToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DoiTuongToChucEntity.Id = Id;
				_DoiTuongToChucEntity.IdDoiTuong = IdDoiTuong;
				_DoiTuongToChucEntity.IdToChuc = IdToChuc;
				_DoiTuongToChucEntity.MaRutGon = MaRutGon;
				_DoiTuongToChucEntity.MaTp = MaTp;
				_DoiTuongToChucEntity.GhiChu = GhiChu;
				_DoiTuongToChucEntity.IdNguoiTao = IdNguoiTao;
				_DoiTuongToChucEntity.NgayTao = NgayTao;
				_DoiTuongToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DoiTuongToChucEntity.NgayCapNhat = NgayCapNhat;
				_DoiTuongToChucEntity.NgayHetHan = NgayHetHan;
				_DoiTuongToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DoiTuongToChucEntity, true);
			}
			return _DoiTuongToChucEntity;
		}

		public DoiTuongToChucEntity Insert(Guid IdDoiTuong, Guid IdToChuc, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DoiTuongToChucEntity _DoiTuongToChucEntity = new DoiTuongToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DoiTuongToChucEntity.IdDoiTuong = IdDoiTuong;
				_DoiTuongToChucEntity.IdToChuc = IdToChuc;
				_DoiTuongToChucEntity.MaRutGon = MaRutGon;
				_DoiTuongToChucEntity.MaTp = MaTp;
				_DoiTuongToChucEntity.GhiChu = GhiChu;
				_DoiTuongToChucEntity.IdNguoiTao = IdNguoiTao;
				_DoiTuongToChucEntity.NgayTao = NgayTao;
				_DoiTuongToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DoiTuongToChucEntity.NgayCapNhat = NgayCapNhat;
				_DoiTuongToChucEntity.NgayHetHan = NgayHetHan;
				_DoiTuongToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DoiTuongToChucEntity, true);
			}
			return _DoiTuongToChucEntity;
		}

		public bool Update(DoiTuongToChucEntity _DoiTuongToChucEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DoiTuongToChucFields.Id == _DoiTuongToChucEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DoiTuongToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DoiTuongToChucEntity _DoiTuongToChucEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DoiTuongToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDoiTuong, Guid IdToChuc, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DoiTuongToChucEntity _DoiTuongToChucEntity = new DoiTuongToChucEntity(Id);
				if (adapter.FetchEntity(_DoiTuongToChucEntity))
				{
				
					_DoiTuongToChucEntity.IdDoiTuong = IdDoiTuong;
					_DoiTuongToChucEntity.IdToChuc = IdToChuc;
					_DoiTuongToChucEntity.MaRutGon = MaRutGon;
					_DoiTuongToChucEntity.MaTp = MaTp;
					_DoiTuongToChucEntity.GhiChu = GhiChu;
					_DoiTuongToChucEntity.IdNguoiTao = IdNguoiTao;
					_DoiTuongToChucEntity.NgayTao = NgayTao;
					_DoiTuongToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_DoiTuongToChucEntity.NgayCapNhat = NgayCapNhat;
					_DoiTuongToChucEntity.NgayHetHan = NgayHetHan;
					_DoiTuongToChucEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_DoiTuongToChucEntity, true);
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
				DoiTuongToChucEntity _DoiTuongToChucEntity = new DoiTuongToChucEntity(Id);
				if (adapter.FetchEntity(_DoiTuongToChucEntity))
				{
					adapter.DeleteEntity(_DoiTuongToChucEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdToChuc(Guid IdToChuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongToChucEntity", filter);
			}
			return toReturn;
		}
		

		
		public DoiTuongToChucEntity SelectOne(Guid Id)
		{
			DoiTuongToChucEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DoiTuongToChucEntity _DoiTuongToChucEntity = new DoiTuongToChucEntity(Id);
				if (adapter.FetchEntity(_DoiTuongToChucEntity))
				{
					toReturn = _DoiTuongToChucEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectAllLST()
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, null, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdToChucLST(Guid IdToChuc)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdToChucLST_Paged(Guid IdToChuc, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdToChucRDT(Guid IdToChuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdToChucRDT_Paged(Guid IdToChuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return EntityCollection<DoiTuongToChucEntity>
		public EntityCollection<DoiTuongToChucEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongToChucEntity> _DoiTuongToChucCollection = new EntityCollection<DoiTuongToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongToChucCollection = new EntityCollection(new DoiTuongToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

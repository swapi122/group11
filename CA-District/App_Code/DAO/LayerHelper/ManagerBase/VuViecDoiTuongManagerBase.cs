




/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecDoiTuongManagerBase
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
	public class VuViecDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public VuViecDoiTuongEntity Insert(VuViecDoiTuongEntity _VuViecDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VuViecDoiTuongEntity, true);
			}
			return _VuViecDoiTuongEntity;
		}

		
		public VuViecDoiTuongEntity Insert(Guid Id, Guid IdVuViec, Guid IdDoiTuong, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			VuViecDoiTuongEntity _VuViecDoiTuongEntity = new VuViecDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecDoiTuongEntity.Id = Id;
				_VuViecDoiTuongEntity.IdVuViec = IdVuViec;
				_VuViecDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_VuViecDoiTuongEntity.MaRutGon = MaRutGon;
				_VuViecDoiTuongEntity.MaTp = MaTp;
				_VuViecDoiTuongEntity.GhiChu = GhiChu;
				_VuViecDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_VuViecDoiTuongEntity.NgayTao = NgayTao;
				_VuViecDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_VuViecDoiTuongEntity.NgayHetHan = NgayHetHan;
				_VuViecDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecDoiTuongEntity, true);
			}
			return _VuViecDoiTuongEntity;
		}

		public VuViecDoiTuongEntity Insert(Guid IdVuViec, Guid IdDoiTuong, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			VuViecDoiTuongEntity _VuViecDoiTuongEntity = new VuViecDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecDoiTuongEntity.IdVuViec = IdVuViec;
				_VuViecDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_VuViecDoiTuongEntity.MaRutGon = MaRutGon;
				_VuViecDoiTuongEntity.MaTp = MaTp;
				_VuViecDoiTuongEntity.GhiChu = GhiChu;
				_VuViecDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_VuViecDoiTuongEntity.NgayTao = NgayTao;
				_VuViecDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_VuViecDoiTuongEntity.NgayHetHan = NgayHetHan;
				_VuViecDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecDoiTuongEntity, true);
			}
			return _VuViecDoiTuongEntity;
		}

		public bool Update(VuViecDoiTuongEntity _VuViecDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VuViecDoiTuongFields.Id == _VuViecDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VuViecDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VuViecDoiTuongEntity _VuViecDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VuViecDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, Guid IdDoiTuong, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecDoiTuongEntity _VuViecDoiTuongEntity = new VuViecDoiTuongEntity(Id);
				if (adapter.FetchEntity(_VuViecDoiTuongEntity))
				{
				
					_VuViecDoiTuongEntity.IdVuViec = IdVuViec;
					_VuViecDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_VuViecDoiTuongEntity.MaRutGon = MaRutGon;
					_VuViecDoiTuongEntity.MaTp = MaTp;
					_VuViecDoiTuongEntity.GhiChu = GhiChu;
					_VuViecDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_VuViecDoiTuongEntity.NgayTao = NgayTao;
					_VuViecDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VuViecDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_VuViecDoiTuongEntity.NgayHetHan = NgayHetHan;
					_VuViecDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VuViecDoiTuongEntity, true);
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
				VuViecDoiTuongEntity _VuViecDoiTuongEntity = new VuViecDoiTuongEntity(Id);
				if (adapter.FetchEntity(_VuViecDoiTuongEntity))
				{
					adapter.DeleteEntity(_VuViecDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public VuViecDoiTuongEntity SelectOne(Guid Id)
		{
			VuViecDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecDoiTuongEntity _VuViecDoiTuongEntity = new VuViecDoiTuongEntity(Id);
				if (adapter.FetchEntity(_VuViecDoiTuongEntity))
				{
					toReturn = _VuViecDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, null, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return EntityCollection<VuViecDoiTuongEntity>
		public EntityCollection<VuViecDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecDoiTuongEntity> _VuViecDoiTuongCollection = new EntityCollection<VuViecDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecDoiTuongCollection = new EntityCollection(new VuViecDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

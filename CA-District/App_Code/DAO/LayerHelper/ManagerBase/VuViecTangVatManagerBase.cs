




/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecTangVatManagerBase
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
	public class VuViecTangVatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecTangVatManagerBase()
		{
			// Nothing for now.
		}
		
		public VuViecTangVatEntity Insert(VuViecTangVatEntity _VuViecTangVatEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VuViecTangVatEntity, true);
			}
			return _VuViecTangVatEntity;
		}

		
		public VuViecTangVatEntity Insert(Guid Id, Guid IdVuViec, Guid IdTangVat, decimal GiaTriTangVat, Guid IdLoaiTien, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecTangVatEntity _VuViecTangVatEntity = new VuViecTangVatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecTangVatEntity.Id = Id;
				_VuViecTangVatEntity.IdVuViec = IdVuViec;
				_VuViecTangVatEntity.IdTangVat = IdTangVat;
				_VuViecTangVatEntity.GiaTriTangVat = GiaTriTangVat;
				_VuViecTangVatEntity.IdLoaiTien = IdLoaiTien;
				_VuViecTangVatEntity.GhiChu = GhiChu;
				_VuViecTangVatEntity.IdNguoiTao = IdNguoiTao;
				_VuViecTangVatEntity.NgayTao = NgayTao;
				_VuViecTangVatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecTangVatEntity.NgayCapNhat = NgayCapNhat;
				_VuViecTangVatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecTangVatEntity, true);
			}
			return _VuViecTangVatEntity;
		}

		public VuViecTangVatEntity Insert(Guid IdVuViec, Guid IdTangVat, decimal GiaTriTangVat, Guid IdLoaiTien, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecTangVatEntity _VuViecTangVatEntity = new VuViecTangVatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecTangVatEntity.IdVuViec = IdVuViec;
				_VuViecTangVatEntity.IdTangVat = IdTangVat;
				_VuViecTangVatEntity.GiaTriTangVat = GiaTriTangVat;
				_VuViecTangVatEntity.IdLoaiTien = IdLoaiTien;
				_VuViecTangVatEntity.GhiChu = GhiChu;
				_VuViecTangVatEntity.IdNguoiTao = IdNguoiTao;
				_VuViecTangVatEntity.NgayTao = NgayTao;
				_VuViecTangVatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecTangVatEntity.NgayCapNhat = NgayCapNhat;
				_VuViecTangVatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecTangVatEntity, true);
			}
			return _VuViecTangVatEntity;
		}

		public bool Update(VuViecTangVatEntity _VuViecTangVatEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VuViecTangVatFields.Id == _VuViecTangVatEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VuViecTangVatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VuViecTangVatEntity _VuViecTangVatEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VuViecTangVatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, Guid IdTangVat, decimal GiaTriTangVat, Guid IdLoaiTien, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecTangVatEntity _VuViecTangVatEntity = new VuViecTangVatEntity(Id);
				if (adapter.FetchEntity(_VuViecTangVatEntity))
				{
				
					_VuViecTangVatEntity.IdVuViec = IdVuViec;
					_VuViecTangVatEntity.IdTangVat = IdTangVat;
					_VuViecTangVatEntity.GiaTriTangVat = GiaTriTangVat;
					_VuViecTangVatEntity.IdLoaiTien = IdLoaiTien;
					_VuViecTangVatEntity.GhiChu = GhiChu;
					_VuViecTangVatEntity.IdNguoiTao = IdNguoiTao;
					_VuViecTangVatEntity.NgayTao = NgayTao;
					_VuViecTangVatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VuViecTangVatEntity.NgayCapNhat = NgayCapNhat;
					_VuViecTangVatEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VuViecTangVatEntity, true);
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
				VuViecTangVatEntity _VuViecTangVatEntity = new VuViecTangVatEntity(Id);
				if (adapter.FetchEntity(_VuViecTangVatEntity))
				{
					adapter.DeleteEntity(_VuViecTangVatEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTangVat(Guid IdTangVat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdTangVat == IdTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGiaTriTangVat(decimal GiaTriTangVat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GiaTriTangVat == GiaTriTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiTien(Guid IdLoaiTien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecTangVatEntity", filter);
			}
			return toReturn;
		}
		

		
		public VuViecTangVatEntity SelectOne(Guid Id)
		{
			VuViecTangVatEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecTangVatEntity _VuViecTangVatEntity = new VuViecTangVatEntity(Id);
				if (adapter.FetchEntity(_VuViecTangVatEntity))
				{
					toReturn = _VuViecTangVatEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectAllLST()
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, null, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdTangVatLST(Guid IdTangVat)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdTangVat == IdTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdTangVatLST_Paged(Guid IdTangVat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdTangVat == IdTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTangVatRDT(Guid IdTangVat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdTangVat == IdTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTangVatRDT_Paged(Guid IdTangVat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdTangVat == IdTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByGiaTriTangVatLST(decimal GiaTriTangVat)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GiaTriTangVat == GiaTriTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByGiaTriTangVatLST_Paged(decimal GiaTriTangVat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GiaTriTangVat == GiaTriTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriTangVatRDT(decimal GiaTriTangVat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GiaTriTangVat == GiaTriTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriTangVatRDT_Paged(decimal GiaTriTangVat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GiaTriTangVat == GiaTriTangVat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdLoaiTienLST(Guid IdLoaiTien)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdLoaiTienLST_Paged(Guid IdLoaiTien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienRDT(Guid IdLoaiTien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienRDT_Paged(Guid IdLoaiTien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return EntityCollection<VuViecTangVatEntity>
		public EntityCollection<VuViecTangVatEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecTangVatEntity> _VuViecTangVatCollection = new EntityCollection<VuViecTangVatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecTangVatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecTangVatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecTangVatCollection = new EntityCollection(new VuViecTangVatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecTangVatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecTangVatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecHauQuaThietHaiManagerBase
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
	public class VuViecHauQuaThietHaiManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecHauQuaThietHaiManagerBase()
		{
			// Nothing for now.
		}
		
		public VuViecHauQuaThietHaiEntity Insert(VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VuViecHauQuaThietHaiEntity, true);
			}
			return _VuViecHauQuaThietHaiEntity;
		}

		
		public VuViecHauQuaThietHaiEntity Insert(Guid Id, Guid IdVuViec, Guid IdThietHai, Guid IdDonViTinh, int SoLuong, decimal GiaTriThietHai, string GhiChu, Guid IdLoaiTien, string MaRutGon, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity = new VuViecHauQuaThietHaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecHauQuaThietHaiEntity.Id = Id;
				_VuViecHauQuaThietHaiEntity.IdVuViec = IdVuViec;
				_VuViecHauQuaThietHaiEntity.IdThietHai = IdThietHai;
				_VuViecHauQuaThietHaiEntity.IdDonViTinh = IdDonViTinh;
				_VuViecHauQuaThietHaiEntity.SoLuong = SoLuong;
				_VuViecHauQuaThietHaiEntity.GiaTriThietHai = GiaTriThietHai;
				_VuViecHauQuaThietHaiEntity.GhiChu = GhiChu;
				_VuViecHauQuaThietHaiEntity.IdLoaiTien = IdLoaiTien;
				_VuViecHauQuaThietHaiEntity.MaRutGon = MaRutGon;
				_VuViecHauQuaThietHaiEntity.IdNguoiTao = IdNguoiTao;
				_VuViecHauQuaThietHaiEntity.NgayTao = NgayTao;
				_VuViecHauQuaThietHaiEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecHauQuaThietHaiEntity.NgayCapNhat = NgayCapNhat;
				_VuViecHauQuaThietHaiEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecHauQuaThietHaiEntity, true);
			}
			return _VuViecHauQuaThietHaiEntity;
		}

		public VuViecHauQuaThietHaiEntity Insert(Guid IdVuViec, Guid IdThietHai, Guid IdDonViTinh, int SoLuong, decimal GiaTriThietHai, string GhiChu, Guid IdLoaiTien, string MaRutGon, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity = new VuViecHauQuaThietHaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecHauQuaThietHaiEntity.IdVuViec = IdVuViec;
				_VuViecHauQuaThietHaiEntity.IdThietHai = IdThietHai;
				_VuViecHauQuaThietHaiEntity.IdDonViTinh = IdDonViTinh;
				_VuViecHauQuaThietHaiEntity.SoLuong = SoLuong;
				_VuViecHauQuaThietHaiEntity.GiaTriThietHai = GiaTriThietHai;
				_VuViecHauQuaThietHaiEntity.GhiChu = GhiChu;
				_VuViecHauQuaThietHaiEntity.IdLoaiTien = IdLoaiTien;
				_VuViecHauQuaThietHaiEntity.MaRutGon = MaRutGon;
				_VuViecHauQuaThietHaiEntity.IdNguoiTao = IdNguoiTao;
				_VuViecHauQuaThietHaiEntity.NgayTao = NgayTao;
				_VuViecHauQuaThietHaiEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecHauQuaThietHaiEntity.NgayCapNhat = NgayCapNhat;
				_VuViecHauQuaThietHaiEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecHauQuaThietHaiEntity, true);
			}
			return _VuViecHauQuaThietHaiEntity;
		}

		public bool Update(VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == _VuViecHauQuaThietHaiEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VuViecHauQuaThietHaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VuViecHauQuaThietHaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, Guid IdThietHai, Guid IdDonViTinh, int SoLuong, decimal GiaTriThietHai, string GhiChu, Guid IdLoaiTien, string MaRutGon, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity = new VuViecHauQuaThietHaiEntity(Id);
				if (adapter.FetchEntity(_VuViecHauQuaThietHaiEntity))
				{
				
					_VuViecHauQuaThietHaiEntity.IdVuViec = IdVuViec;
					_VuViecHauQuaThietHaiEntity.IdThietHai = IdThietHai;
					_VuViecHauQuaThietHaiEntity.IdDonViTinh = IdDonViTinh;
					_VuViecHauQuaThietHaiEntity.SoLuong = SoLuong;
					_VuViecHauQuaThietHaiEntity.GiaTriThietHai = GiaTriThietHai;
					_VuViecHauQuaThietHaiEntity.GhiChu = GhiChu;
					_VuViecHauQuaThietHaiEntity.IdLoaiTien = IdLoaiTien;
					_VuViecHauQuaThietHaiEntity.MaRutGon = MaRutGon;
					_VuViecHauQuaThietHaiEntity.IdNguoiTao = IdNguoiTao;
					_VuViecHauQuaThietHaiEntity.NgayTao = NgayTao;
					_VuViecHauQuaThietHaiEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VuViecHauQuaThietHaiEntity.NgayCapNhat = NgayCapNhat;
					_VuViecHauQuaThietHaiEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VuViecHauQuaThietHaiEntity, true);
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
				VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity = new VuViecHauQuaThietHaiEntity(Id);
				if (adapter.FetchEntity(_VuViecHauQuaThietHaiEntity))
				{
					adapter.DeleteEntity(_VuViecHauQuaThietHaiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdThietHai(Guid IdThietHai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdThietHai == IdThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViTinh(Guid IdDonViTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdDonViTinh == IdDonViTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoLuong(int SoLuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.SoLuong == SoLuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGiaTriThietHai(decimal GiaTriThietHai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GiaTriThietHai == GiaTriThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiTien(Guid IdLoaiTien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecHauQuaThietHaiEntity", filter);
			}
			return toReturn;
		}
		

		
		public VuViecHauQuaThietHaiEntity SelectOne(Guid Id)
		{
			VuViecHauQuaThietHaiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecHauQuaThietHaiEntity _VuViecHauQuaThietHaiEntity = new VuViecHauQuaThietHaiEntity(Id);
				if (adapter.FetchEntity(_VuViecHauQuaThietHaiEntity))
				{
					toReturn = _VuViecHauQuaThietHaiEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectAllLST()
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, null, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdThietHaiLST(Guid IdThietHai)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdThietHai == IdThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdThietHaiLST_Paged(Guid IdThietHai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdThietHai == IdThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdThietHaiRDT(Guid IdThietHai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdThietHai == IdThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdThietHaiRDT_Paged(Guid IdThietHai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdThietHai == IdThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdDonViTinhLST(Guid IdDonViTinh)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdDonViTinh == IdDonViTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdDonViTinhLST_Paged(Guid IdDonViTinh, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdDonViTinh == IdDonViTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViTinhRDT(Guid IdDonViTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdDonViTinh == IdDonViTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViTinhRDT_Paged(Guid IdDonViTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdDonViTinh == IdDonViTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectBySoLuongLST(int SoLuong)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.SoLuong == SoLuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectBySoLuongLST_Paged(int SoLuong, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.SoLuong == SoLuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoLuongRDT(int SoLuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.SoLuong == SoLuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoLuongRDT_Paged(int SoLuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.SoLuong == SoLuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByGiaTriThietHaiLST(decimal GiaTriThietHai)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GiaTriThietHai == GiaTriThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByGiaTriThietHaiLST_Paged(decimal GiaTriThietHai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GiaTriThietHai == GiaTriThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriThietHaiRDT(decimal GiaTriThietHai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GiaTriThietHai == GiaTriThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGiaTriThietHaiRDT_Paged(decimal GiaTriThietHai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GiaTriThietHai == GiaTriThietHai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdLoaiTienLST(Guid IdLoaiTien)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdLoaiTienLST_Paged(Guid IdLoaiTien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienRDT(Guid IdLoaiTien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienRDT_Paged(Guid IdLoaiTien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdLoaiTien == IdLoaiTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return EntityCollection<VuViecHauQuaThietHaiEntity>
		public EntityCollection<VuViecHauQuaThietHaiEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecHauQuaThietHaiEntity> _VuViecHauQuaThietHaiCollection = new EntityCollection<VuViecHauQuaThietHaiEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecHauQuaThietHaiCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecHauQuaThietHaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecHauQuaThietHaiCollection = new EntityCollection(new VuViecHauQuaThietHaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecHauQuaThietHaiFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecHauQuaThietHaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}

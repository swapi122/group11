




/*
'===============================================================================
'  LayerHelper.CAQ.BL.VuViecXuLyManagerBase
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
	public class VuViecXuLyManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public VuViecXuLyManagerBase()
		{
			// Nothing for now.
		}
		
		public VuViecXuLyEntity Insert(VuViecXuLyEntity _VuViecXuLyEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_VuViecXuLyEntity, true);
			}
			return _VuViecXuLyEntity;
		}

		
		public VuViecXuLyEntity Insert(Guid Id, Guid IdVuViec, Guid IdCapChiDao, string NoiDung, string KetQuaThucHien, Guid IdDonViXuLy, Guid IdHinhThucXuLy, string SoHinhThucXuLy, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecXuLyEntity _VuViecXuLyEntity = new VuViecXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecXuLyEntity.Id = Id;
				_VuViecXuLyEntity.IdVuViec = IdVuViec;
				_VuViecXuLyEntity.IdCapChiDao = IdCapChiDao;
				_VuViecXuLyEntity.NoiDung = NoiDung;
				_VuViecXuLyEntity.KetQuaThucHien = KetQuaThucHien;
				_VuViecXuLyEntity.IdDonViXuLy = IdDonViXuLy;
				_VuViecXuLyEntity.IdHinhThucXuLy = IdHinhThucXuLy;
				_VuViecXuLyEntity.SoHinhThucXuLy = SoHinhThucXuLy;
				_VuViecXuLyEntity.NgayXuLy = NgayXuLy;
				_VuViecXuLyEntity.NgayKetLuan = NgayKetLuan;
				_VuViecXuLyEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
				_VuViecXuLyEntity.NgayDinhChi = NgayDinhChi;
				_VuViecXuLyEntity.SoBanAn = SoBanAn;
				_VuViecXuLyEntity.NgayBanAn = NgayBanAn;
				_VuViecXuLyEntity.IdNguoiTao = IdNguoiTao;
				_VuViecXuLyEntity.NgayTao = NgayTao;
				_VuViecXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecXuLyEntity.NgayCapNhat = NgayCapNhat;
				_VuViecXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecXuLyEntity, true);
			}
			return _VuViecXuLyEntity;
		}

		public VuViecXuLyEntity Insert(Guid IdVuViec, Guid IdCapChiDao, string NoiDung, string KetQuaThucHien, Guid IdDonViXuLy, Guid IdHinhThucXuLy, string SoHinhThucXuLy, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			VuViecXuLyEntity _VuViecXuLyEntity = new VuViecXuLyEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_VuViecXuLyEntity.IdVuViec = IdVuViec;
				_VuViecXuLyEntity.IdCapChiDao = IdCapChiDao;
				_VuViecXuLyEntity.NoiDung = NoiDung;
				_VuViecXuLyEntity.KetQuaThucHien = KetQuaThucHien;
				_VuViecXuLyEntity.IdDonViXuLy = IdDonViXuLy;
				_VuViecXuLyEntity.IdHinhThucXuLy = IdHinhThucXuLy;
				_VuViecXuLyEntity.SoHinhThucXuLy = SoHinhThucXuLy;
				_VuViecXuLyEntity.NgayXuLy = NgayXuLy;
				_VuViecXuLyEntity.NgayKetLuan = NgayKetLuan;
				_VuViecXuLyEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
				_VuViecXuLyEntity.NgayDinhChi = NgayDinhChi;
				_VuViecXuLyEntity.SoBanAn = SoBanAn;
				_VuViecXuLyEntity.NgayBanAn = NgayBanAn;
				_VuViecXuLyEntity.IdNguoiTao = IdNguoiTao;
				_VuViecXuLyEntity.NgayTao = NgayTao;
				_VuViecXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_VuViecXuLyEntity.NgayCapNhat = NgayCapNhat;
				_VuViecXuLyEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_VuViecXuLyEntity, true);
			}
			return _VuViecXuLyEntity;
		}

		public bool Update(VuViecXuLyEntity _VuViecXuLyEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(VuViecXuLyFields.Id == _VuViecXuLyEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_VuViecXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(VuViecXuLyEntity _VuViecXuLyEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_VuViecXuLyEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdVuViec, Guid IdCapChiDao, string NoiDung, string KetQuaThucHien, Guid IdDonViXuLy, Guid IdHinhThucXuLy, string SoHinhThucXuLy, DateTime NgayXuLy, DateTime NgayKetLuan, string SoDinhChiTamDinhChi, DateTime NgayDinhChi, string SoBanAn, DateTime NgayBanAn, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecXuLyEntity _VuViecXuLyEntity = new VuViecXuLyEntity(Id);
				if (adapter.FetchEntity(_VuViecXuLyEntity))
				{
				
					_VuViecXuLyEntity.IdVuViec = IdVuViec;
					_VuViecXuLyEntity.IdCapChiDao = IdCapChiDao;
					_VuViecXuLyEntity.NoiDung = NoiDung;
					_VuViecXuLyEntity.KetQuaThucHien = KetQuaThucHien;
					_VuViecXuLyEntity.IdDonViXuLy = IdDonViXuLy;
					_VuViecXuLyEntity.IdHinhThucXuLy = IdHinhThucXuLy;
					_VuViecXuLyEntity.SoHinhThucXuLy = SoHinhThucXuLy;
					_VuViecXuLyEntity.NgayXuLy = NgayXuLy;
					_VuViecXuLyEntity.NgayKetLuan = NgayKetLuan;
					_VuViecXuLyEntity.SoDinhChiTamDinhChi = SoDinhChiTamDinhChi;
					_VuViecXuLyEntity.NgayDinhChi = NgayDinhChi;
					_VuViecXuLyEntity.SoBanAn = SoBanAn;
					_VuViecXuLyEntity.NgayBanAn = NgayBanAn;
					_VuViecXuLyEntity.IdNguoiTao = IdNguoiTao;
					_VuViecXuLyEntity.NgayTao = NgayTao;
					_VuViecXuLyEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_VuViecXuLyEntity.NgayCapNhat = NgayCapNhat;
					_VuViecXuLyEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_VuViecXuLyEntity, true);
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
				VuViecXuLyEntity _VuViecXuLyEntity = new VuViecXuLyEntity(Id);
				if (adapter.FetchEntity(_VuViecXuLyEntity))
				{
					adapter.DeleteEntity(_VuViecXuLyEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuViec(Guid IdVuViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdCapChiDao(Guid IdCapChiDao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdCapChiDao == IdCapChiDao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDung(string NoiDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByKetQuaThucHien(string KetQuaThucHien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.KetQuaThucHien == KetQuaThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViXuLy(Guid IdDonViXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHinhThucXuLy(string SoHinhThucXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoHinhThucXuLy == SoHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayKetLuan(DateTime NgayKetLuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayDinhChi(DateTime NgayDinhChi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoBanAn(string SoBanAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBanAn(DateTime NgayBanAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("VuViecXuLyEntity", filter);
			}
			return toReturn;
		}
		

		
		public VuViecXuLyEntity SelectOne(Guid Id)
		{
			VuViecXuLyEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				VuViecXuLyEntity _VuViecXuLyEntity = new VuViecXuLyEntity(Id);
				if (adapter.FetchEntity(_VuViecXuLyEntity))
				{
					toReturn = _VuViecXuLyEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectAllLST()
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, null, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdVuViecLST(Guid IdVuViec)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdVuViecLST_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT(Guid IdVuViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuViecRDT_Paged(Guid IdVuViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdVuViec == IdVuViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdCapChiDaoLST(Guid IdCapChiDao)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdCapChiDao == IdCapChiDao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdCapChiDaoLST_Paged(Guid IdCapChiDao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdCapChiDao == IdCapChiDao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdCapChiDaoRDT(Guid IdCapChiDao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdCapChiDao == IdCapChiDao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdCapChiDaoRDT_Paged(Guid IdCapChiDao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdCapChiDao == IdCapChiDao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNoiDungLST(string NoiDung)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNoiDungLST_Paged(string NoiDung, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungRDT(string NoiDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungRDT_Paged(string NoiDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByKetQuaThucHienLST(string KetQuaThucHien)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.KetQuaThucHien == KetQuaThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByKetQuaThucHienLST_Paged(string KetQuaThucHien, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.KetQuaThucHien == KetQuaThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByKetQuaThucHienRDT(string KetQuaThucHien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.KetQuaThucHien == KetQuaThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByKetQuaThucHienRDT_Paged(string KetQuaThucHien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.KetQuaThucHien == KetQuaThucHien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdDonViXuLyLST(Guid IdDonViXuLy)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdDonViXuLyLST_Paged(Guid IdDonViXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViXuLyRDT(Guid IdDonViXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViXuLyRDT_Paged(Guid IdDonViXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdDonViXuLy == IdDonViXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdHinhThucXuLyLST(Guid IdHinhThucXuLy)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdHinhThucXuLyLST_Paged(Guid IdHinhThucXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyRDT(Guid IdHinhThucXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyRDT_Paged(Guid IdHinhThucXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoHinhThucXuLyLST(string SoHinhThucXuLy)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoHinhThucXuLy == SoHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoHinhThucXuLyLST_Paged(string SoHinhThucXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoHinhThucXuLy == SoHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHinhThucXuLyRDT(string SoHinhThucXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoHinhThucXuLy == SoHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHinhThucXuLyRDT_Paged(string SoHinhThucXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoHinhThucXuLy == SoHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayXuLyLST(DateTime NgayXuLy)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayXuLyLST_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT(DateTime NgayXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayKetLuanLST(DateTime NgayKetLuan)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayKetLuanLST_Paged(DateTime NgayKetLuan, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetLuanRDT(DateTime NgayKetLuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetLuanRDT_Paged(DateTime NgayKetLuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayKetLuan == NgayKetLuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoDinhChiTamDinhChiLST(string SoDinhChiTamDinhChi)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoDinhChiTamDinhChiLST_Paged(string SoDinhChiTamDinhChi, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDinhChiTamDinhChiRDT(string SoDinhChiTamDinhChi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDinhChiTamDinhChiRDT_Paged(string SoDinhChiTamDinhChi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayDinhChiLST(DateTime NgayDinhChi)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayDinhChiLST_Paged(DateTime NgayDinhChi, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDinhChiRDT(DateTime NgayDinhChi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDinhChiRDT_Paged(DateTime NgayDinhChi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayDinhChi == NgayDinhChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoBanAnLST(string SoBanAn)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectBySoBanAnLST_Paged(string SoBanAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoBanAnRDT(string SoBanAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoBanAnRDT_Paged(string SoBanAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.SoBanAn == SoBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayBanAnLST(DateTime NgayBanAn)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayBanAnLST_Paged(DateTime NgayBanAn, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBanAnRDT(DateTime NgayBanAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBanAnRDT_Paged(DateTime NgayBanAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayBanAn == NgayBanAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return EntityCollection<VuViecXuLyEntity>
		public EntityCollection<VuViecXuLyEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<VuViecXuLyEntity> _VuViecXuLyCollection = new EntityCollection<VuViecXuLyEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_VuViecXuLyCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _VuViecXuLyCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _VuViecXuLyCollection = new EntityCollection(new VuViecXuLyEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(VuViecXuLyFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_VuViecXuLyCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.NgheNghiepDoiTuongManagerBase
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
	public class NgheNghiepDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NgheNghiepDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public NgheNghiepDoiTuongEntity Insert(NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NgheNghiepDoiTuongEntity, true);
			}
			return _NgheNghiepDoiTuongEntity;
		}

		
		public NgheNghiepDoiTuongEntity Insert(Guid Id, Guid IdLoaiCoQuan, Guid IdNgheNghiep, Guid IdDoiTuong, Guid IdChucVu, string NoiLamViec, string TinhTrangNgheNghiep, string TongHop, string GhiChu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity = new NgheNghiepDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NgheNghiepDoiTuongEntity.Id = Id;
				_NgheNghiepDoiTuongEntity.IdLoaiCoQuan = IdLoaiCoQuan;
				_NgheNghiepDoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
				_NgheNghiepDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_NgheNghiepDoiTuongEntity.IdChucVu = IdChucVu;
				_NgheNghiepDoiTuongEntity.NoiLamViec = NoiLamViec;
				_NgheNghiepDoiTuongEntity.TinhTrangNgheNghiep = TinhTrangNgheNghiep;
				_NgheNghiepDoiTuongEntity.TongHop = TongHop;
				_NgheNghiepDoiTuongEntity.GhiChu = GhiChu;
				_NgheNghiepDoiTuongEntity.MaRutGon = MaRutGon;
				_NgheNghiepDoiTuongEntity.MaTp = MaTp;
				_NgheNghiepDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NgheNghiepDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_NgheNghiepDoiTuongEntity.NgayTao = NgayTao;
				_NgheNghiepDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NgheNghiepDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_NgheNghiepDoiTuongEntity.NgayHetHan = NgayHetHan;
				_NgheNghiepDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NgheNghiepDoiTuongEntity, true);
			}
			return _NgheNghiepDoiTuongEntity;
		}

		public NgheNghiepDoiTuongEntity Insert(Guid IdLoaiCoQuan, Guid IdNgheNghiep, Guid IdDoiTuong, Guid IdChucVu, string NoiLamViec, string TinhTrangNgheNghiep, string TongHop, string GhiChu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity = new NgheNghiepDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NgheNghiepDoiTuongEntity.IdLoaiCoQuan = IdLoaiCoQuan;
				_NgheNghiepDoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
				_NgheNghiepDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_NgheNghiepDoiTuongEntity.IdChucVu = IdChucVu;
				_NgheNghiepDoiTuongEntity.NoiLamViec = NoiLamViec;
				_NgheNghiepDoiTuongEntity.TinhTrangNgheNghiep = TinhTrangNgheNghiep;
				_NgheNghiepDoiTuongEntity.TongHop = TongHop;
				_NgheNghiepDoiTuongEntity.GhiChu = GhiChu;
				_NgheNghiepDoiTuongEntity.MaRutGon = MaRutGon;
				_NgheNghiepDoiTuongEntity.MaTp = MaTp;
				_NgheNghiepDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_NgheNghiepDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_NgheNghiepDoiTuongEntity.NgayTao = NgayTao;
				_NgheNghiepDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_NgheNghiepDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_NgheNghiepDoiTuongEntity.NgayHetHan = NgayHetHan;
				_NgheNghiepDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_NgheNghiepDoiTuongEntity, true);
			}
			return _NgheNghiepDoiTuongEntity;
		}

		public bool Update(NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == _NgheNghiepDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NgheNghiepDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NgheNghiepDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdLoaiCoQuan, Guid IdNgheNghiep, Guid IdDoiTuong, Guid IdChucVu, string NoiLamViec, string TinhTrangNgheNghiep, string TongHop, string GhiChu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity = new NgheNghiepDoiTuongEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepDoiTuongEntity))
				{
				
					_NgheNghiepDoiTuongEntity.IdLoaiCoQuan = IdLoaiCoQuan;
					_NgheNghiepDoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
					_NgheNghiepDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_NgheNghiepDoiTuongEntity.IdChucVu = IdChucVu;
					_NgheNghiepDoiTuongEntity.NoiLamViec = NoiLamViec;
					_NgheNghiepDoiTuongEntity.TinhTrangNgheNghiep = TinhTrangNgheNghiep;
					_NgheNghiepDoiTuongEntity.TongHop = TongHop;
					_NgheNghiepDoiTuongEntity.GhiChu = GhiChu;
					_NgheNghiepDoiTuongEntity.MaRutGon = MaRutGon;
					_NgheNghiepDoiTuongEntity.MaTp = MaTp;
					_NgheNghiepDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_NgheNghiepDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_NgheNghiepDoiTuongEntity.NgayTao = NgayTao;
					_NgheNghiepDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_NgheNghiepDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_NgheNghiepDoiTuongEntity.NgayHetHan = NgayHetHan;
					_NgheNghiepDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_NgheNghiepDoiTuongEntity, true);
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
				NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity = new NgheNghiepDoiTuongEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepDoiTuongEntity))
				{
					adapter.DeleteEntity(_NgheNghiepDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiCoQuan(Guid IdLoaiCoQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdLoaiCoQuan == IdLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdChucVu(Guid IdChucVu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiLamViec(string NoiLamViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTinhTrangNgheNghiep(string TinhTrangNgheNghiep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TinhTrangNgheNghiep == TinhTrangNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongHop(string TongHop)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NgheNghiepDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public NgheNghiepDoiTuongEntity SelectOne(Guid Id)
		{
			NgheNghiepDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NgheNghiepDoiTuongEntity _NgheNghiepDoiTuongEntity = new NgheNghiepDoiTuongEntity(Id);
				if (adapter.FetchEntity(_NgheNghiepDoiTuongEntity))
				{
					toReturn = _NgheNghiepDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, null, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdLoaiCoQuanLST(Guid IdLoaiCoQuan)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdLoaiCoQuan == IdLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdLoaiCoQuanLST_Paged(Guid IdLoaiCoQuan, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdLoaiCoQuan == IdLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiCoQuanRDT(Guid IdLoaiCoQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdLoaiCoQuan == IdLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiCoQuanRDT_Paged(Guid IdLoaiCoQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdLoaiCoQuan == IdLoaiCoQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNgheNghiepLST(Guid IdNgheNghiep)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNgheNghiepLST_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT(Guid IdNgheNghiep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdChucVuLST(Guid IdChucVu)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdChucVuLST_Paged(Guid IdChucVu, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucVuRDT(Guid IdChucVu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucVuRDT_Paged(Guid IdChucVu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNoiLamViecLST(string NoiLamViec)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNoiLamViecLST_Paged(string NoiLamViec, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiLamViecRDT(string NoiLamViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiLamViecRDT_Paged(string NoiLamViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTinhTrangNgheNghiepLST(string TinhTrangNgheNghiep)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TinhTrangNgheNghiep == TinhTrangNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTinhTrangNgheNghiepLST_Paged(string TinhTrangNgheNghiep, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TinhTrangNgheNghiep == TinhTrangNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTinhTrangNgheNghiepRDT(string TinhTrangNgheNghiep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TinhTrangNgheNghiep == TinhTrangNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTinhTrangNgheNghiepRDT_Paged(string TinhTrangNgheNghiep, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TinhTrangNgheNghiep == TinhTrangNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTongHopLST(string TongHop)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTongHopLST_Paged(string TongHop, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT(string TongHop)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT_Paged(string TongHop, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return EntityCollection<NgheNghiepDoiTuongEntity>
		public EntityCollection<NgheNghiepDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<NgheNghiepDoiTuongEntity> _NgheNghiepDoiTuongCollection = new EntityCollection<NgheNghiepDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NgheNghiepDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NgheNghiepDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NgheNghiepDoiTuongCollection = new EntityCollection(new NgheNghiepDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NgheNghiepDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NgheNghiepDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}






/*
'===============================================================================
'  LayerHelper.CAQ.BL.ThongTinBatManagerBase
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
	public class ThongTinBatManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThongTinBatManagerBase()
		{
			// Nothing for now.
		}
		
		public ThongTinBatEntity Insert(ThongTinBatEntity _ThongTinBatEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ThongTinBatEntity, true);
			}
			return _ThongTinBatEntity;
		}

		
		public ThongTinBatEntity Insert(Guid Id, Guid IdDoiTuong, string SoKhoiTo, DateTime NgayKhoiTo, string SoLenhBat, DateTime NgayRaLenhBat, DateTime NgayBat, string SoPhong, string TinhChat, Guid IdTruongHopBat, string LenhTamGiu, DateTime NgayTamGiu, DateTime GiaHanTamGiu, string LenhTamGiam, DateTime NgayTamGiam, DateTime GiaHanTamGiam, Guid IdDieuKhoiTo, Guid IdVuAn, string DoiTuongDungDau, Guid IdHinhThucXuLy, DateTime NgayXuLy, string MucXuLy, string DonViThuLy, string CanBoDieuTra, string SoHoSo, DateTime NgayLap, string SoNopLuu, DateTime NgayLuu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			ThongTinBatEntity _ThongTinBatEntity = new ThongTinBatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThongTinBatEntity.Id = Id;
				_ThongTinBatEntity.IdDoiTuong = IdDoiTuong;
				_ThongTinBatEntity.SoKhoiTo = SoKhoiTo;
				_ThongTinBatEntity.NgayKhoiTo = NgayKhoiTo;
				_ThongTinBatEntity.SoLenhBat = SoLenhBat;
				_ThongTinBatEntity.NgayRaLenhBat = NgayRaLenhBat;
				_ThongTinBatEntity.NgayBat = NgayBat;
				_ThongTinBatEntity.SoPhong = SoPhong;
				_ThongTinBatEntity.TinhChat = TinhChat;
				_ThongTinBatEntity.IdTruongHopBat = IdTruongHopBat;
				_ThongTinBatEntity.LenhTamGiu = LenhTamGiu;
				_ThongTinBatEntity.NgayTamGiu = NgayTamGiu;
				_ThongTinBatEntity.GiaHanTamGiu = GiaHanTamGiu;
				_ThongTinBatEntity.LenhTamGiam = LenhTamGiam;
				_ThongTinBatEntity.NgayTamGiam = NgayTamGiam;
				_ThongTinBatEntity.GiaHanTamGiam = GiaHanTamGiam;
				_ThongTinBatEntity.IdDieuKhoiTo = IdDieuKhoiTo;
				_ThongTinBatEntity.IdVuAn = IdVuAn;
				_ThongTinBatEntity.DoiTuongDungDau = DoiTuongDungDau;
				_ThongTinBatEntity.IdHinhThucXuLy = IdHinhThucXuLy;
				_ThongTinBatEntity.NgayXuLy = NgayXuLy;
				_ThongTinBatEntity.MucXuLy = MucXuLy;
				_ThongTinBatEntity.DonViThuLy = DonViThuLy;
				_ThongTinBatEntity.CanBoDieuTra = CanBoDieuTra;
				_ThongTinBatEntity.SoHoSo = SoHoSo;
				_ThongTinBatEntity.NgayLap = NgayLap;
				_ThongTinBatEntity.SoNopLuu = SoNopLuu;
				_ThongTinBatEntity.NgayLuu = NgayLuu;
				_ThongTinBatEntity.MaRutGon = MaRutGon;
				_ThongTinBatEntity.MaTp = MaTp;
				_ThongTinBatEntity.LoaiDanhMuc = LoaiDanhMuc;
				_ThongTinBatEntity.IdNguoiTao = IdNguoiTao;
				_ThongTinBatEntity.NgayTao = NgayTao;
				_ThongTinBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ThongTinBatEntity.NgayCapNhat = NgayCapNhat;
				_ThongTinBatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ThongTinBatEntity, true);
			}
			return _ThongTinBatEntity;
		}

		public ThongTinBatEntity Insert(Guid IdDoiTuong, string SoKhoiTo, DateTime NgayKhoiTo, string SoLenhBat, DateTime NgayRaLenhBat, DateTime NgayBat, string SoPhong, string TinhChat, Guid IdTruongHopBat, string LenhTamGiu, DateTime NgayTamGiu, DateTime GiaHanTamGiu, string LenhTamGiam, DateTime NgayTamGiam, DateTime GiaHanTamGiam, Guid IdDieuKhoiTo, Guid IdVuAn, string DoiTuongDungDau, Guid IdHinhThucXuLy, DateTime NgayXuLy, string MucXuLy, string DonViThuLy, string CanBoDieuTra, string SoHoSo, DateTime NgayLap, string SoNopLuu, DateTime NgayLuu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			ThongTinBatEntity _ThongTinBatEntity = new ThongTinBatEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThongTinBatEntity.IdDoiTuong = IdDoiTuong;
				_ThongTinBatEntity.SoKhoiTo = SoKhoiTo;
				_ThongTinBatEntity.NgayKhoiTo = NgayKhoiTo;
				_ThongTinBatEntity.SoLenhBat = SoLenhBat;
				_ThongTinBatEntity.NgayRaLenhBat = NgayRaLenhBat;
				_ThongTinBatEntity.NgayBat = NgayBat;
				_ThongTinBatEntity.SoPhong = SoPhong;
				_ThongTinBatEntity.TinhChat = TinhChat;
				_ThongTinBatEntity.IdTruongHopBat = IdTruongHopBat;
				_ThongTinBatEntity.LenhTamGiu = LenhTamGiu;
				_ThongTinBatEntity.NgayTamGiu = NgayTamGiu;
				_ThongTinBatEntity.GiaHanTamGiu = GiaHanTamGiu;
				_ThongTinBatEntity.LenhTamGiam = LenhTamGiam;
				_ThongTinBatEntity.NgayTamGiam = NgayTamGiam;
				_ThongTinBatEntity.GiaHanTamGiam = GiaHanTamGiam;
				_ThongTinBatEntity.IdDieuKhoiTo = IdDieuKhoiTo;
				_ThongTinBatEntity.IdVuAn = IdVuAn;
				_ThongTinBatEntity.DoiTuongDungDau = DoiTuongDungDau;
				_ThongTinBatEntity.IdHinhThucXuLy = IdHinhThucXuLy;
				_ThongTinBatEntity.NgayXuLy = NgayXuLy;
				_ThongTinBatEntity.MucXuLy = MucXuLy;
				_ThongTinBatEntity.DonViThuLy = DonViThuLy;
				_ThongTinBatEntity.CanBoDieuTra = CanBoDieuTra;
				_ThongTinBatEntity.SoHoSo = SoHoSo;
				_ThongTinBatEntity.NgayLap = NgayLap;
				_ThongTinBatEntity.SoNopLuu = SoNopLuu;
				_ThongTinBatEntity.NgayLuu = NgayLuu;
				_ThongTinBatEntity.MaRutGon = MaRutGon;
				_ThongTinBatEntity.MaTp = MaTp;
				_ThongTinBatEntity.LoaiDanhMuc = LoaiDanhMuc;
				_ThongTinBatEntity.IdNguoiTao = IdNguoiTao;
				_ThongTinBatEntity.NgayTao = NgayTao;
				_ThongTinBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ThongTinBatEntity.NgayCapNhat = NgayCapNhat;
				_ThongTinBatEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ThongTinBatEntity, true);
			}
			return _ThongTinBatEntity;
		}

		public bool Update(ThongTinBatEntity _ThongTinBatEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ThongTinBatFields.Id == _ThongTinBatEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ThongTinBatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ThongTinBatEntity _ThongTinBatEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ThongTinBatEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDoiTuong, string SoKhoiTo, DateTime NgayKhoiTo, string SoLenhBat, DateTime NgayRaLenhBat, DateTime NgayBat, string SoPhong, string TinhChat, Guid IdTruongHopBat, string LenhTamGiu, DateTime NgayTamGiu, DateTime GiaHanTamGiu, string LenhTamGiam, DateTime NgayTamGiam, DateTime GiaHanTamGiam, Guid IdDieuKhoiTo, Guid IdVuAn, string DoiTuongDungDau, Guid IdHinhThucXuLy, DateTime NgayXuLy, string MucXuLy, string DonViThuLy, string CanBoDieuTra, string SoHoSo, DateTime NgayLap, string SoNopLuu, DateTime NgayLuu, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThongTinBatEntity _ThongTinBatEntity = new ThongTinBatEntity(Id);
				if (adapter.FetchEntity(_ThongTinBatEntity))
				{
				
					_ThongTinBatEntity.IdDoiTuong = IdDoiTuong;
					_ThongTinBatEntity.SoKhoiTo = SoKhoiTo;
					_ThongTinBatEntity.NgayKhoiTo = NgayKhoiTo;
					_ThongTinBatEntity.SoLenhBat = SoLenhBat;
					_ThongTinBatEntity.NgayRaLenhBat = NgayRaLenhBat;
					_ThongTinBatEntity.NgayBat = NgayBat;
					_ThongTinBatEntity.SoPhong = SoPhong;
					_ThongTinBatEntity.TinhChat = TinhChat;
					_ThongTinBatEntity.IdTruongHopBat = IdTruongHopBat;
					_ThongTinBatEntity.LenhTamGiu = LenhTamGiu;
					_ThongTinBatEntity.NgayTamGiu = NgayTamGiu;
					_ThongTinBatEntity.GiaHanTamGiu = GiaHanTamGiu;
					_ThongTinBatEntity.LenhTamGiam = LenhTamGiam;
					_ThongTinBatEntity.NgayTamGiam = NgayTamGiam;
					_ThongTinBatEntity.GiaHanTamGiam = GiaHanTamGiam;
					_ThongTinBatEntity.IdDieuKhoiTo = IdDieuKhoiTo;
					_ThongTinBatEntity.IdVuAn = IdVuAn;
					_ThongTinBatEntity.DoiTuongDungDau = DoiTuongDungDau;
					_ThongTinBatEntity.IdHinhThucXuLy = IdHinhThucXuLy;
					_ThongTinBatEntity.NgayXuLy = NgayXuLy;
					_ThongTinBatEntity.MucXuLy = MucXuLy;
					_ThongTinBatEntity.DonViThuLy = DonViThuLy;
					_ThongTinBatEntity.CanBoDieuTra = CanBoDieuTra;
					_ThongTinBatEntity.SoHoSo = SoHoSo;
					_ThongTinBatEntity.NgayLap = NgayLap;
					_ThongTinBatEntity.SoNopLuu = SoNopLuu;
					_ThongTinBatEntity.NgayLuu = NgayLuu;
					_ThongTinBatEntity.MaRutGon = MaRutGon;
					_ThongTinBatEntity.MaTp = MaTp;
					_ThongTinBatEntity.LoaiDanhMuc = LoaiDanhMuc;
					_ThongTinBatEntity.IdNguoiTao = IdNguoiTao;
					_ThongTinBatEntity.NgayTao = NgayTao;
					_ThongTinBatEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_ThongTinBatEntity.NgayCapNhat = NgayCapNhat;
					_ThongTinBatEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_ThongTinBatEntity, true);
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
				ThongTinBatEntity _ThongTinBatEntity = new ThongTinBatEntity(Id);
				if (adapter.FetchEntity(_ThongTinBatEntity))
				{
					adapter.DeleteEntity(_ThongTinBatEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ThongTinBatEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoKhoiTo(string SoKhoiTo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoKhoiTo == SoKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayKhoiTo(DateTime NgayKhoiTo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayKhoiTo == NgayKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoLenhBat(string SoLenhBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoLenhBat == SoLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayRaLenhBat(DateTime NgayRaLenhBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayRaLenhBat == NgayRaLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBat(DateTime NgayBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoPhong(string SoPhong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoPhong == SoPhong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTinhChat(string TinhChat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TinhChat == TinhChat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTruongHopBat(Guid IdTruongHopBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLenhTamGiu(string LenhTamGiu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiu == LenhTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTamGiu(DateTime NgayTamGiu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiu == NgayTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGiaHanTamGiu(DateTime GiaHanTamGiu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiu == GiaHanTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLenhTamGiam(string LenhTamGiam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiam == LenhTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTamGiam(DateTime NgayTamGiam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiam == NgayTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGiaHanTamGiam(DateTime GiaHanTamGiam)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiam == GiaHanTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDieuKhoiTo(Guid IdDieuKhoiTo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDieuKhoiTo == IdDieuKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVuAn(Guid IdVuAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdVuAn == IdVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDoiTuongDungDau(string DoiTuongDungDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMucXuLy(string MucXuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MucXuLy == MucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDonViThuLy(string DonViThuLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DonViThuLy == DonViThuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCanBoDieuTra(string CanBoDieuTra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.CanBoDieuTra == CanBoDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHoSo(string SoHoSo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayLap(DateTime NgayLap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLap == NgayLap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNopLuu(string SoNopLuu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayLuu(DateTime NgayLuu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLuu == NgayLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThongTinBatEntity", filter);
			}
			return toReturn;
		}
		

		
		public ThongTinBatEntity SelectOne(Guid Id)
		{
			ThongTinBatEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThongTinBatEntity _ThongTinBatEntity = new ThongTinBatEntity(Id);
				if (adapter.FetchEntity(_ThongTinBatEntity))
				{
					toReturn = _ThongTinBatEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectAllLST()
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, null, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoKhoiToLST(string SoKhoiTo)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoKhoiTo == SoKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoKhoiToLST_Paged(string SoKhoiTo, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoKhoiTo == SoKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoKhoiToRDT(string SoKhoiTo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoKhoiTo == SoKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoKhoiToRDT_Paged(string SoKhoiTo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoKhoiTo == SoKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayKhoiToLST(DateTime NgayKhoiTo)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayKhoiTo == NgayKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayKhoiToLST_Paged(DateTime NgayKhoiTo, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayKhoiTo == NgayKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKhoiToRDT(DateTime NgayKhoiTo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayKhoiTo == NgayKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKhoiToRDT_Paged(DateTime NgayKhoiTo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayKhoiTo == NgayKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoLenhBatLST(string SoLenhBat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoLenhBat == SoLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoLenhBatLST_Paged(string SoLenhBat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoLenhBat == SoLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoLenhBatRDT(string SoLenhBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoLenhBat == SoLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoLenhBatRDT_Paged(string SoLenhBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoLenhBat == SoLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayRaLenhBatLST(DateTime NgayRaLenhBat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayRaLenhBat == NgayRaLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayRaLenhBatLST_Paged(DateTime NgayRaLenhBat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayRaLenhBat == NgayRaLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayRaLenhBatRDT(DateTime NgayRaLenhBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayRaLenhBat == NgayRaLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayRaLenhBatRDT_Paged(DateTime NgayRaLenhBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayRaLenhBat == NgayRaLenhBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayBatLST(DateTime NgayBat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayBatLST_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT(DateTime NgayBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoPhongLST(string SoPhong)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoPhong == SoPhong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoPhongLST_Paged(string SoPhong, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoPhong == SoPhong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoPhongRDT(string SoPhong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoPhong == SoPhong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoPhongRDT_Paged(string SoPhong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoPhong == SoPhong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByTinhChatLST(string TinhChat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TinhChat == TinhChat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByTinhChatLST_Paged(string TinhChat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TinhChat == TinhChat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTinhChatRDT(string TinhChat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TinhChat == TinhChat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTinhChatRDT_Paged(string TinhChat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TinhChat == TinhChat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdTruongHopBatLST(Guid IdTruongHopBat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdTruongHopBatLST_Paged(Guid IdTruongHopBat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTruongHopBatRDT(Guid IdTruongHopBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTruongHopBatRDT_Paged(Guid IdTruongHopBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLenhTamGiuLST(string LenhTamGiu)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiu == LenhTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLenhTamGiuLST_Paged(string LenhTamGiu, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiu == LenhTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLenhTamGiuRDT(string LenhTamGiu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiu == LenhTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLenhTamGiuRDT_Paged(string LenhTamGiu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiu == LenhTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTamGiuLST(DateTime NgayTamGiu)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiu == NgayTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTamGiuLST_Paged(DateTime NgayTamGiu, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiu == NgayTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTamGiuRDT(DateTime NgayTamGiu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiu == NgayTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTamGiuRDT_Paged(DateTime NgayTamGiu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiu == NgayTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByGiaHanTamGiuLST(DateTime GiaHanTamGiu)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiu == GiaHanTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByGiaHanTamGiuLST_Paged(DateTime GiaHanTamGiu, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiu == GiaHanTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGiaHanTamGiuRDT(DateTime GiaHanTamGiu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiu == GiaHanTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGiaHanTamGiuRDT_Paged(DateTime GiaHanTamGiu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiu == GiaHanTamGiu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLenhTamGiamLST(string LenhTamGiam)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiam == LenhTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLenhTamGiamLST_Paged(string LenhTamGiam, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiam == LenhTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLenhTamGiamRDT(string LenhTamGiam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiam == LenhTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLenhTamGiamRDT_Paged(string LenhTamGiam, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LenhTamGiam == LenhTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTamGiamLST(DateTime NgayTamGiam)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiam == NgayTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTamGiamLST_Paged(DateTime NgayTamGiam, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiam == NgayTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTamGiamRDT(DateTime NgayTamGiam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiam == NgayTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTamGiamRDT_Paged(DateTime NgayTamGiam, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTamGiam == NgayTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByGiaHanTamGiamLST(DateTime GiaHanTamGiam)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiam == GiaHanTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByGiaHanTamGiamLST_Paged(DateTime GiaHanTamGiam, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiam == GiaHanTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGiaHanTamGiamRDT(DateTime GiaHanTamGiam)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiam == GiaHanTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGiaHanTamGiamRDT_Paged(DateTime GiaHanTamGiam, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.GiaHanTamGiam == GiaHanTamGiam);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdDieuKhoiToLST(Guid IdDieuKhoiTo)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDieuKhoiTo == IdDieuKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdDieuKhoiToLST_Paged(Guid IdDieuKhoiTo, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDieuKhoiTo == IdDieuKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDieuKhoiToRDT(Guid IdDieuKhoiTo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDieuKhoiTo == IdDieuKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDieuKhoiToRDT_Paged(Guid IdDieuKhoiTo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdDieuKhoiTo == IdDieuKhoiTo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdVuAnLST(Guid IdVuAn)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdVuAn == IdVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdVuAnLST_Paged(Guid IdVuAn, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdVuAn == IdVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuAnRDT(Guid IdVuAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdVuAn == IdVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVuAnRDT_Paged(Guid IdVuAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdVuAn == IdVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByDoiTuongDungDauLST(string DoiTuongDungDau)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByDoiTuongDungDauLST_Paged(string DoiTuongDungDau, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDoiTuongDungDauRDT(string DoiTuongDungDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDoiTuongDungDauRDT_Paged(string DoiTuongDungDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdHinhThucXuLyLST(Guid IdHinhThucXuLy)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdHinhThucXuLyLST_Paged(Guid IdHinhThucXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyRDT(Guid IdHinhThucXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHinhThucXuLyRDT_Paged(Guid IdHinhThucXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdHinhThucXuLy == IdHinhThucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayXuLyLST(DateTime NgayXuLy)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayXuLyLST_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT(DateTime NgayXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXuLyRDT_Paged(DateTime NgayXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayXuLy == NgayXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMucXuLyLST(string MucXuLy)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MucXuLy == MucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMucXuLyLST_Paged(string MucXuLy, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MucXuLy == MucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMucXuLyRDT(string MucXuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MucXuLy == MucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMucXuLyRDT_Paged(string MucXuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MucXuLy == MucXuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByDonViThuLyLST(string DonViThuLy)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DonViThuLy == DonViThuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByDonViThuLyLST_Paged(string DonViThuLy, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DonViThuLy == DonViThuLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDonViThuLyRDT(string DonViThuLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DonViThuLy == DonViThuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDonViThuLyRDT_Paged(string DonViThuLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.DonViThuLy == DonViThuLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByCanBoDieuTraLST(string CanBoDieuTra)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.CanBoDieuTra == CanBoDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByCanBoDieuTraLST_Paged(string CanBoDieuTra, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.CanBoDieuTra == CanBoDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCanBoDieuTraRDT(string CanBoDieuTra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.CanBoDieuTra == CanBoDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCanBoDieuTraRDT_Paged(string CanBoDieuTra, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.CanBoDieuTra == CanBoDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoHoSoLST(string SoHoSo)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoHoSoLST_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT(string SoHoSo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayLapLST(DateTime NgayLap)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLap == NgayLap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayLapLST_Paged(DateTime NgayLap, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLap == NgayLap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayLapRDT(DateTime NgayLap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLap == NgayLap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayLapRDT_Paged(DateTime NgayLap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLap == NgayLap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoNopLuuLST(string SoNopLuu)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectBySoNopLuuLST_Paged(string SoNopLuu, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNopLuuRDT(string SoNopLuu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNopLuuRDT_Paged(string SoNopLuu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.SoNopLuu == SoNopLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayLuuLST(DateTime NgayLuu)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLuu == NgayLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayLuuLST_Paged(DateTime NgayLuu, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLuu == NgayLuu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayLuuRDT(DateTime NgayLuu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLuu == NgayLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayLuuRDT_Paged(DateTime NgayLuu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayLuu == NgayLuu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null);
			}
			return _ThongTinBatCollection;
		}
		
		// Return EntityCollection<ThongTinBatEntity>
		public EntityCollection<ThongTinBatEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<ThongTinBatEntity> _ThongTinBatCollection = new EntityCollection<ThongTinBatEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThongTinBatCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ThongTinBatCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThongTinBatCollection = new EntityCollection(new ThongTinBatEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThongTinBatFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThongTinBatCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
